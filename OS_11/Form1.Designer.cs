namespace OS_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dir1 = new System.Windows.Forms.TextBox();
            this.dir2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mem1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mem2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Button();
            this.search1 = new System.Windows.Forms.Button();
            this.search2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please, enter the 1st directory:";
            // 
            // dir1
            // 
            this.dir1.Location = new System.Drawing.Point(49, 88);
            this.dir1.Name = "dir1";
            this.dir1.Size = new System.Drawing.Size(315, 22);
            this.dir1.TabIndex = 1;
            this.dir1.TextChanged += new System.EventHandler(this.dir1_TextChanged);
            // 
            // dir2
            // 
            this.dir2.Location = new System.Drawing.Point(49, 233);
            this.dir2.Name = "dir2";
            this.dir2.Size = new System.Drawing.Size(315, 22);
            this.dir2.TabIndex = 3;
            this.dir2.TextChanged += new System.EventHandler(this.dir2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please, enter the 2nd directory:";
            // 
            // mem1
            // 
            this.mem1.Location = new System.Drawing.Point(672, 88);
            this.mem1.Name = "mem1";
            this.mem1.ReadOnly = true;
            this.mem1.Size = new System.Drawing.Size(141, 22);
            this.mem1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Whole memory amount, bytes:";
            // 
            // mem2
            // 
            this.mem2.Location = new System.Drawing.Point(672, 233);
            this.mem2.Name = "mem2";
            this.mem2.ReadOnly = true;
            this.mem2.Size = new System.Drawing.Size(141, 22);
            this.mem2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Whole memory amount, bytes:";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(672, 348);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(141, 50);
            this.process.TabIndex = 8;
            this.process.Text = "Process";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(389, 86);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(122, 27);
            this.search1.TabIndex = 9;
            this.search1.Text = "Search";
            this.search1.UseVisualStyleBackColor = true;
            this.search1.Click += new System.EventHandler(this.button2_Click);
            // 
            // search2
            // 
            this.search2.Location = new System.Drawing.Point(389, 228);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(122, 27);
            this.search2.TabIndex = 10;
            this.search2.Text = "Search";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.search2);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.process);
            this.Controls.Add(this.mem2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mem1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dir2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dir1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dir1;
        private System.Windows.Forms.TextBox dir2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mem2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Button search1;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}

