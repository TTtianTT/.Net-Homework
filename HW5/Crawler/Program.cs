
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
                String startUrl = "http://www.cnblogs.com/";
                if (args.Length >= 1) startUrl = args[0];
                Crawler myCrawler = new Crawler(startUrl);
                new Thread(myCrawler.Crawl).Start();      
        }
    }
}
