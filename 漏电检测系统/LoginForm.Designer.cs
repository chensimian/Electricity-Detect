namespace 漏电检测系统
{
    partial class LoginForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.TEXT_Password = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.TEXT_UserName = new System.Windows.Forms.TextBox();
			this.Btn_Load = new System.Windows.Forms.Button();
			this.PB_Password = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PB_Password)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(365, 93);
			this.panel2.TabIndex = 22;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImage = global::漏电检测系统.Properties.Resources.People;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox4.Location = new System.Drawing.Point(147, 12);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(91, 75);
			this.pictureBox4.TabIndex = 26;
			this.pictureBox4.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.panel6);
			this.panel1.Controls.Add(this.panel5);
			this.panel1.Controls.Add(this.Btn_Load);
			this.panel1.Controls.Add(this.PB_Password);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 93);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(365, 213);
			this.panel1.TabIndex = 23;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.panel6.Controls.Add(this.TEXT_Password);
			this.panel6.Location = new System.Drawing.Point(49, 58);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(288, 49);
			this.panel6.TabIndex = 25;
			// 
			// TEXT_Password
			// 
			this.TEXT_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.TEXT_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TEXT_Password.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TEXT_Password.ForeColor = System.Drawing.Color.Gray;
			this.TEXT_Password.Location = new System.Drawing.Point(3, 8);
			this.TEXT_Password.Name = "TEXT_Password";
			this.TEXT_Password.PasswordChar = '*';
			this.TEXT_Password.Size = new System.Drawing.Size(282, 34);
			this.TEXT_Password.TabIndex = 13;
			this.TEXT_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.panel5.Controls.Add(this.TEXT_UserName);
			this.panel5.Location = new System.Drawing.Point(49, 4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(288, 49);
			this.panel5.TabIndex = 24;
			// 
			// TEXT_UserName
			// 
			this.TEXT_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.TEXT_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TEXT_UserName.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.TEXT_UserName.ForeColor = System.Drawing.Color.Gray;
			this.TEXT_UserName.Location = new System.Drawing.Point(3, 8);
			this.TEXT_UserName.Name = "TEXT_UserName";
			this.TEXT_UserName.Size = new System.Drawing.Size(282, 34);
			this.TEXT_UserName.TabIndex = 12;
			this.TEXT_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TEXT_UserName.TextChanged += new System.EventHandler(this.TEXT_UserName_TextChanged);
			// 
			// Btn_Load
			// 
			this.Btn_Load.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.Btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Load.Font = new System.Drawing.Font("宋体", 21.75F);
			this.Btn_Load.ForeColor = System.Drawing.SystemColors.Control;
			this.Btn_Load.Location = new System.Drawing.Point(49, 128);
			this.Btn_Load.Name = "Btn_Load";
			this.Btn_Load.Size = new System.Drawing.Size(288, 49);
			this.Btn_Load.TabIndex = 15;
			this.Btn_Load.Text = "登录";
			this.Btn_Load.UseVisualStyleBackColor = false;
			this.Btn_Load.Click += new System.EventHandler(this.Btn_Load_Click);
			// 
			// PB_Password
			// 
			this.PB_Password.BackgroundImage = global::漏电检测系统.Properties.Resources.Lock;
			this.PB_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PB_Password.Location = new System.Drawing.Point(12, 66);
			this.PB_Password.Name = "PB_Password";
			this.PB_Password.Size = new System.Drawing.Size(31, 31);
			this.PB_Password.TabIndex = 22;
			this.PB_Password.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = global::漏电检测系统.Properties.Resources.People;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(31, 31);
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(365, 306);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "漏电检测系统";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PB_Password)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TEXT_Password;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TEXT_UserName;
        private System.Windows.Forms.Button Btn_Load;
        private System.Windows.Forms.PictureBox PB_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

