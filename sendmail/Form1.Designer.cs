namespace sendmail
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.mm_txt = new System.Windows.Forms.TextBox();
            this.yjshou_txt = new System.Windows.Forms.TextBox();
            this.zt_txt = new System.Windows.Forms.TextBox();
            this.content_txt = new System.Windows.Forms.TextBox();
            this.yj_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "主题";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "收件人邮箱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "密 码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "用户名：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Tag = " ";
            this.button1.Text = "发 送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "发件人邮箱";
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(99, 103);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(100, 21);
            this.user_txt.TabIndex = 2;
            // 
            // mm_txt
            // 
            this.mm_txt.Location = new System.Drawing.Point(99, 147);
            this.mm_txt.Name = "mm_txt";
            this.mm_txt.PasswordChar = '*';
            this.mm_txt.Size = new System.Drawing.Size(100, 21);
            this.mm_txt.TabIndex = 3;
            // 
            // yjshou_txt
            // 
            this.yjshou_txt.Location = new System.Drawing.Point(99, 193);
            this.yjshou_txt.Name = "yjshou_txt";
            this.yjshou_txt.Size = new System.Drawing.Size(100, 21);
            this.yjshou_txt.TabIndex = 4;
            // 
            // zt_txt
            // 
            this.zt_txt.Location = new System.Drawing.Point(99, 236);
            this.zt_txt.Name = "zt_txt";
            this.zt_txt.Size = new System.Drawing.Size(100, 21);
            this.zt_txt.TabIndex = 5;
            // 
            // content_txt
            // 
            this.content_txt.Location = new System.Drawing.Point(228, 49);
            this.content_txt.Multiline = true;
            this.content_txt.Name = "content_txt";
            this.content_txt.Size = new System.Drawing.Size(268, 220);
            this.content_txt.TabIndex = 6;
            // 
            // yj_txt
            // 
            this.yj_txt.Location = new System.Drawing.Point(99, 50);
            this.yj_txt.Name = "yj_txt";
            this.yj_txt.Size = new System.Drawing.Size(100, 21);
            this.yj_txt.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 389);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.mm_txt);
            this.Controls.Add(this.yjshou_txt);
            this.Controls.Add(this.zt_txt);
            this.Controls.Add(this.content_txt);
            this.Controls.Add(this.yj_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox mm_txt;
        private System.Windows.Forms.TextBox yjshou_txt;
        private System.Windows.Forms.TextBox zt_txt;
        private System.Windows.Forms.TextBox content_txt;
        private System.Windows.Forms.TextBox yj_txt;
    }
}

