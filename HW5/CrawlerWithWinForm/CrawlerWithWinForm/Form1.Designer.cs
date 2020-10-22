using System;

namespace CrawlerWithWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStartUrl = new System.Windows.Forms.TextBox();
            this.lbxFinish = new System.Windows.Forms.ListBox();
            this.lbxError = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStartUrl
            // 
            this.txtStartUrl.Location = new System.Drawing.Point(3, 3);
            this.txtStartUrl.Name = "txtStartUrl";
            this.txtStartUrl.Size = new System.Drawing.Size(172, 25);
            this.txtStartUrl.TabIndex = 0;
            this.txtStartUrl.Text = "https://www.cnblog.com/";
            // 
            // lbxFinish
            // 
            this.lbxFinish.FormattingEnabled = true;
            this.lbxFinish.ItemHeight = 15;
            this.lbxFinish.Location = new System.Drawing.Point(333, 45);
            this.lbxFinish.Name = "lbxFinish";
            this.lbxFinish.Size = new System.Drawing.Size(346, 184);
            this.lbxFinish.TabIndex = 1;
            // 
            // lbxError
            // 
            this.lbxError.FormattingEnabled = true;
            this.lbxError.ItemHeight = 15;
            this.lbxError.Location = new System.Drawing.Point(3, 45);
            this.lbxError.Name = "lbxError";
            this.lbxError.Size = new System.Drawing.Size(324, 184);
            this.lbxError.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "结束";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtStartUrl);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.lbxError);
            this.flowLayoutPanel1.Controls.Add(this.lbxFinish);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(683, 313);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TextBox txtStartUrl;
        private System.Windows.Forms.ListBox lbxFinish;
        private System.Windows.Forms.ListBox lbxError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

