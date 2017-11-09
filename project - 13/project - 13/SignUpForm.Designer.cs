namespace project___13
{
    partial class SignUpForm
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
            this.labelFName = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LasNameBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PassworsLabel = new System.Windows.Forms.Label();
            this.FaceBookEmailText = new System.Windows.Forms.TextBox();
            this.FaceBookLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(11, 82);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(60, 13);
            this.labelFName.TabIndex = 0;
            this.labelFName.Text = "First Name:";
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(10, 108);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(61, 13);
            this.LabelLastName.TabIndex = 1;
            this.LabelLastName.Text = "Last Name:";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(96, 82);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(174, 20);
            this.FirstNameBox.TabIndex = 2;
            // 
            // LasNameBox
            // 
            this.LasNameBox.Location = new System.Drawing.Point(96, 108);
            this.LasNameBox.Name = "LasNameBox";
            this.LasNameBox.Size = new System.Drawing.Size(174, 20);
            this.LasNameBox.TabIndex = 3;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(223, 42);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(124, 13);
            this.Title.TabIndex = 4;
            this.Title.Text = "Welcom! Enter your data";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(96, 134);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(174, 20);
            this.UserNameBox.TabIndex = 6;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(10, 134);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 13);
            this.UserNameLabel.TabIndex = 5;
            this.UserNameLabel.Text = "User Name:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(96, 160);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(174, 20);
            this.PasswordBox.TabIndex = 10;
            // 
            // PassworsLabel
            // 
            this.PassworsLabel.AutoSize = true;
            this.PassworsLabel.Location = new System.Drawing.Point(10, 160);
            this.PassworsLabel.Name = "PassworsLabel";
            this.PassworsLabel.Size = new System.Drawing.Size(59, 13);
            this.PassworsLabel.TabIndex = 9;
            this.PassworsLabel.Text = "Password: ";
            // 
            // FaceBookEmailText
            // 
            this.FaceBookEmailText.Location = new System.Drawing.Point(96, 186);
            this.FaceBookEmailText.Name = "FaceBookEmailText";
            this.FaceBookEmailText.Size = new System.Drawing.Size(174, 20);
            this.FaceBookEmailText.TabIndex = 12;
            // 
            // FaceBookLabel
            // 
            this.FaceBookLabel.AutoSize = true;
            this.FaceBookLabel.Location = new System.Drawing.Point(10, 186);
            this.FaceBookLabel.Name = "FaceBookLabel";
            this.FaceBookLabel.Size = new System.Drawing.Size(89, 13);
            this.FaceBookLabel.TabIndex = 11;
            this.FaceBookLabel.Text = "Facebook Email: ";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(529, 246);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(351, 124);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(75, 23);
            this.SignUpBtn.TabIndex = 15;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 281);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.FaceBookEmailText);
            this.Controls.Add(this.FaceBookLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PassworsLabel);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LasNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.labelFName);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUpForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LasNameBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label PassworsLabel;
        private System.Windows.Forms.TextBox FaceBookEmailText;
        private System.Windows.Forms.Label FaceBookLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SignUpBtn;
    }
}