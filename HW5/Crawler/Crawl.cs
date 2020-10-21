using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Crawler
{
    public class Crawler
    {
        private ConcurrentDictionary<String, bool> urls;
        private ConcurrentQueue<String> queue;
        private int count;
        private int taskCount;
        private String originalSite;  //原始网址

        public Crawler(String startUrl)
        {
            urls = new ConcurrentDictionary<string, bool>();
            urls.TryAdd(startUrl, false);
            queue = new ConcurrentQueue<String>();
            queue.Enqueue(startUrl);
            count = 0;
            taskCount = 0;
            //求原始网址
            int startIndex = startUrl.IndexOf(":") + 3, endIndex = startUrl.IndexOf("/", startIndex);
            originalSite = startUrl.Substring(startIndex, endIndex - startIndex);
        }

        public void Crawl()
        {
            while (count < 100 && (taskCount > 0 || queue.Count > 0))
            {
                string current;
                if (!queue.TryDequeue(out current))
                {
                    continue;
                }
                Console.WriteLine("爬行" + current + "页面!");
                Task task = Task.Run(() => OperateUrl(current));
                count++;
                taskCount++;
            }
        }
        //对指定的url进行操作，包括下载html和解析url
        public void OperateUrl(string url)
        {
            string html = DownLoad(url);
            urls[url] = true;
            Parse(url, html);
            taskCount--;
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = Task.CurrentId.ToString();
                File.WriteAllText(fileName + ".html", html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        private void Parse(string current, string html)
        {
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""']";

            //求当前网页的网页前缀，用于将相对地址转换为绝对地址
            int endIndex = current.IndexOf("/", current.IndexOf(":") + 3);
            string prefix = current.Substring(0, endIndex);
            string protocol = current.Substring(0, current.IndexOf(":"));

            string htmlPattern = @"(.html|.htm)";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                //将相对地址转换为绝对地址
                if (!Regex.IsMatch(strRef, @"://"))
                {
                    if (Regex.IsMatch(strRef, @"^[a-zA-Z0-9]"))
                    {
                        strRef = new Regex(@"[^/]+$").Replace(current, strRef);
                    }
                    else if (strRef.StartsWith("//"))
                    {
                        strRef = protocol + ":" + strRef;
                    }
                    else if (strRef.StartsWith("/"))
                    {
                        strRef = prefix + strRef;
                    }
                    else if (strRef.StartsWith("./"))
                    {
                        strRef = new Regex(@"/[^/]/$").Replace(current, strRef.Substring(2, strRef.Length - 2));
                    }
                    else if (strRef.StartsWith("../"))
                    {
                        while (strRef.StartsWith("../"))
                        {
                            strRef = new Regex(@"[^/]+/[^/]+$").Replace(current, strRef);
                        }
                    }
                }
                if (!Regex.IsMatch(strRef, originalSite)) continue;  //只爬取原始网站上的信息
                if (!Regex.IsMatch(strRef, htmlPattern)) continue;  //只爬取html文本
                if (!urls.Keys.Contains(strRef))
                {
                    Console.WriteLine($"{strRef}");
                    urls.TryAdd(strRef, false);
                    queue.Enqueue(strRef);
                }
            }
        }
    }
}
