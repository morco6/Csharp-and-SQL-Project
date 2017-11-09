namespace project___13.forms
{
    partial class SearchAndChooseUser
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AllUsers = new System.Windows.Forms.ComboBox();
            this.RemoveUserButton = new System.Windows.Forms.Button();
            this.ShowPassButton = new System.Windows.Forms.Button();
            this.Addcoursebutton = new System.Windows.Forms.Button();
            this.SetPremission = new System.Windows.Forms.Button();
            this.PremissionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "תבחר שם משתמש";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(314, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = ":רשימת משתמשים";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AllUsers
            // 
            this.AllUsers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AllUsers.FormattingEnabled = true;
            this.AllUsers.Location = new System.Drawing.Point(187, 43);
            this.AllUsers.Name = "AllUsers";
            this.AllUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllUsers.Size = new System.Drawing.Size(121, 21);
            this.AllUsers.TabIndex = 2;
            this.AllUsers.SelectedIndexChanged += new System.EventHandler(this.AllUsers_SelectedIndexChanged);
            // 
            // RemoveUserButton
            // 
            this.RemoveUserButton.ForeColor = System.Drawing.Color.Black;
            this.RemoveUserButton.Location = new System.Drawing.Point(314, 90);
            this.RemoveUserButton.Name = "RemoveUserButton";
            this.RemoveUserButton.Size = new System.Drawing.Size(120, 23);
            this.RemoveUserButton.TabIndex = 3;
            this.RemoveUserButton.Text = "הסרת משתמש";
            this.RemoveUserButton.UseVisualStyleBackColor = true;
            this.RemoveUserButton.Click += new System.EventHandler(this.RemoveUserButton_Click);
            // 
            // ShowPassButton
            // 
            this.ShowPassButton.ForeColor = System.Drawing.Color.Black;
            this.ShowPassButton.Location = new System.Drawing.Point(187, 90);
            this.ShowPassButton.Name = "ShowPassButton";
            this.ShowPassButton.Size = new System.Drawing.Size(120, 23);
            this.ShowPassButton.TabIndex = 4;
            this.ShowPassButton.Text = "הצגת סיסמה";
            this.ShowPassButton.UseVisualStyleBackColor = true;
            this.ShowPassButton.Click += new System.EventHandler(this.ShowPassButton_Click);
            // 
            // Addcoursebutton
            // 
            this.Addcoursebutton.ForeColor = System.Drawing.Color.Black;
            this.Addcoursebutton.Location = new System.Drawing.Point(314, 119);
            this.Addcoursebutton.Name = "Addcoursebutton";
            this.Addcoursebutton.Size = new System.Drawing.Size(120, 23);
            this.Addcoursebutton.TabIndex = 4;
            this.Addcoursebutton.Text = "הוסף מקצוע";
            this.Addcoursebutton.UseVisualStyleBackColor = true;
            this.Addcoursebutton.Visible = false;
            this.Addcoursebutton.Click += new System.EventHandler(this.Addcoursebutton_Click);
            // 
            // SetPremission
            // 
            this.SetPremission.ForeColor = System.Drawing.Color.Black;
            this.SetPremission.Location = new System.Drawing.Point(188, 119);
            this.SetPremission.Name = "SetPremission";
            this.SetPremission.Size = new System.Drawing.Size(120, 23);
            this.SetPremission.TabIndex = 5;
            this.SetPremission.Text = "שנה הרשאה";
            this.SetPremission.UseVisualStyleBackColor = true;
            this.SetPremission.Click += new System.EventHandler(this.SetPremission_Click);
            // 
            // PremissionComboBox
            // 
            this.PremissionComboBox.FormattingEnabled = true;
            this.PremissionComboBox.Items.AddRange(new object[] {
            "1-מזכירה",
            "2-מתרגל",
            "3-מרצה",
            "4-ראש מחלקה"});
            this.PremissionComboBox.Location = new System.Drawing.Point(49, 119);
            this.PremissionComboBox.Name = "PremissionComboBox";
            this.PremissionComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PremissionComboBox.Size = new System.Drawing.Size(121, 21);
            this.PremissionComboBox.TabIndex = 6;
            this.PremissionComboBox.Visible = false;
            this.PremissionComboBox.SelectedIndexChanged += new System.EventHandler(this.PremissionComboBox_SelectedIndexChanged);
            // 
            // SearchAndChooseUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(441, 165);
            this.Controls.Add(this.PremissionComboBox);
            this.Controls.Add(this.SetPremission);
            this.Controls.Add(this.Addcoursebutton);
            this.Controls.Add(this.ShowPassButton);
            this.Controls.Add(this.RemoveUserButton);
            this.Controls.Add(this.AllUsers);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.MaximumSize = new System.Drawing.Size(457, 204);
            this.MinimumSize = new System.Drawing.Size(457, 204);
            this.Name = "SearchAndChooseUser";
            this.Text = "SearchAndChooseUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchAndChooseUser_FormClosed);
            this.Load += new System.EventHandler(this.SearchAndChooseUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox AllUsers;
        private System.Windows.Forms.Button RemoveUserButton;
        private System.Windows.Forms.Button ShowPassButton;
        private System.Windows.Forms.Button Addcoursebutton;
        private System.Windows.Forms.Button SetPremission;
        private System.Windows.Forms.ComboBox PremissionComboBox;
    }
}