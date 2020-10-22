namespace CaylayTree
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.n_txtBox = new System.Windows.Forms.TextBox();
            this.leng_txtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.per1_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.per2_txtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.th1_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.th2_txtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "绘制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "递归深度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n_txtBox
            // 
            this.n_txtBox.Location = new System.Drawing.Point(584, 40);
            this.n_txtBox.Name = "n_txtBox";
            this.n_txtBox.Size = new System.Drawing.Size(100, 25);
            this.n_txtBox.TabIndex = 2;
            this.n_txtBox.Text = "10";
            // 
            // leng_txtBox
            // 
            this.leng_txtBox.Location = new System.Drawing.Point(584, 98);
            this.leng_txtBox.Name = "leng_txtBox";
            this.leng_txtBox.Size = new System.Drawing.Size(100, 25);
            this.leng_txtBox.TabIndex = 4;
            this.leng_txtBox.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "主干长度";
            // 
            // per1_txtBox
            // 
            this.per1_txtBox.Location = new System.Drawing.Point(584, 160);
            this.per1_txtBox.Name = "per1_txtBox";
            this.per1_txtBox.Size = new System.Drawing.Size(100, 25);
            this.per1_txtBox.TabIndex = 6;
            this.per1_txtBox.Text = "0.6";
            this.per1_txtBox.TextChanged += new System.EventHandler(this.per1_txtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "右分支长度比";
            // 
            // per2_txtBox
            // 
            this.per2_txtBox.Location = new System.Drawing.Point(584, 224);
            this.per2_txtBox.Name = "per2_txtBox";
            this.per2_txtBox.Size = new System.Drawing.Size(100, 25);
            this.per2_txtBox.TabIndex = 8;
            this.per2_txtBox.Text = "0.7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "左分支长度比";
            // 
            // th1_txtBox
            // 
            this.th1_txtBox.Location = new System.Drawing.Point(584, 295);
            this.th1_txtBox.Name = "th1_txtBox";
            this.th1_txtBox.Size = new System.Drawing.Size(100, 25);
            this.th1_txtBox.TabIndex = 10;
            this.th1_txtBox.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "右分支角度";
            // 
            // th2_txtBox
            // 
            this.th2_txtBox.Location = new System.Drawing.Point(584, 359);
            this.th2_txtBox.Name = "th2_txtBox";
            this.th2_txtBox.Size = new System.Drawing.Size(100, 25);
            this.th2_txtBox.TabIndex = 12;
            this.th2_txtBox.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "左分支角度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(485, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "画笔颜色";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "Purple",
            "Pink"});
            this.comboBox1.Location = new System.Drawing.Point(584, 416);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.th2_txtBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.th1_txtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.per2_txtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.per1_txtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.leng_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_txtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n_txtBox;
        private System.Windows.Forms.TextBox leng_txtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox per1_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox per2_txtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox th1_txtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox th2_txtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

