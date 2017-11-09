namespace project___13
{
    partial class login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.user_name = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login_b = new System.Windows.Forms.Button();
            this.login_fb_b = new System.Windows.Forms.Button();
            this.faq_b = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faq_b)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(251, 317);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(167, 20);
            this.user_name.TabIndex = 0;
            this.user_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 361);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // login_b
            // 
            this.login_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_b.BackgroundImage")));
            this.login_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_b.FlatAppearance.BorderSize = 0;
            this.login_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_b.Location = new System.Drawing.Point(133, 361);
            this.login_b.Name = "login_b";
            this.login_b.Size = new System.Drawing.Size(75, 23);
            this.login_b.TabIndex = 3;
            this.login_b.UseVisualStyleBackColor = false;
            this.login_b.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_fb_b
            // 
            this.login_fb_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_fb_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_fb_b.BackgroundImage")));
            this.login_fb_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_fb_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_fb_b.Location = new System.Drawing.Point(133, 396);
            this.login_fb_b.Margin = new System.Windows.Forms.Padding(1);
            this.login_fb_b.Name = "login_fb_b";
            this.login_fb_b.Size = new System.Drawing.Size(136, 22);
            this.login_fb_b.TabIndex = 5;
            this.login_fb_b.UseVisualStyleBackColor = false;
            this.login_fb_b.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // faq_b
            // 
            this.faq_b.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.faq_b.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("faq_b.BackgroundImage")));
            this.faq_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.faq_b.Location = new System.Drawing.Point(14, 16);
            this.faq_b.Margin = new System.Windows.Forms.Padding(2);
            this.faq_b.Name = "faq_b";
            this.faq_b.Size = new System.Drawing.Size(47, 48);
            this.faq_b.TabIndex = 6;
            this.faq_b.TabStop = false;
            this.faq_b.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(14, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 285);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(9, 261);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 18);
            this.button3.TabIndex = 0;
            this.button3.Text = "הבנתי";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(354, 389);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "שחזור סיסמה";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(712, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(752, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.faq_b);
            this.Controls.Add(this.login_fb_b);
            this.Controls.Add(this.login_b);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.user_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(752, 559);
            this.MinimumSize = new System.Drawing.Size(744, 393);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.login_form_FormClosed_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.faq_b)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button login_b;
        private System.Windows.Forms.Button login_fb_b;
        private System.Windows.Forms.PictureBox faq_b;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}

    