namespace project___13
{
    partial class Admin_form_add_new_user
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
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.permission_box = new System.Windows.Forms.ComboBox();
            this.ADD = new System.Windows.Forms.Button();
            this.username_exist = new System.Windows.Forms.Label();
            this.tooShort = new System.Windows.Forms.Label();
            this.passwordvalidationtextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordvalidation = new System.Windows.Forms.Label();
            this.InvalidMailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(233, 6);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernamebox.Size = new System.Drawing.Size(100, 20);
            this.usernamebox.TabIndex = 0;
            this.usernamebox.TextChanged += new System.EventHandler(this.User_name_text_box);
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(233, 46);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordbox.Size = new System.Drawing.Size(100, 20);
            this.passwordbox.TabIndex = 0;
            this.passwordbox.TextChanged += new System.EventHandler(this.password_text_box);
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(233, 167);
            this.firstname.Name = "firstname";
            this.firstname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstname.Size = new System.Drawing.Size(100, 20);
            this.firstname.TabIndex = 0;
            this.firstname.TextChanged += new System.EventHandler(this.first_name_box);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(233, 203);
            this.lastname.Name = "lastname";
            this.lastname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastname.Size = new System.Drawing.Size(100, 20);
            this.lastname.TabIndex = 0;
            this.lastname.TextChanged += new System.EventHandler(this.Last_name_box);
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(233, 243);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EMAIL.Size = new System.Drawing.Size(100, 20);
            this.EMAIL.TabIndex = 0;
            this.EMAIL.TextChanged += new System.EventHandler(this.Email_texxt_box);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "שם משתמש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "סיסמא";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "תפקיד";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "שם פרטי";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "שם משפחה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "דוא\'\'ל";
            // 
            // permission_box
            // 
            this.permission_box.FormattingEnabled = true;
            this.permission_box.Items.AddRange(new object[] {
            "Secretary",
            "Practitioner",
            "Lecturer",
            "Department manager"});
            this.permission_box.Location = new System.Drawing.Point(233, 126);
            this.permission_box.Name = "permission_box";
            this.permission_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.permission_box.Size = new System.Drawing.Size(100, 21);
            this.permission_box.TabIndex = 3;
            this.permission_box.SelectedIndexChanged += new System.EventHandler(this.Select_user_permission);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(40, 364);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(120, 49);
            this.ADD.TabIndex = 4;
            this.ADD.Text = "הוסף משתמש";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // username_exist
            // 
            this.username_exist.AutoSize = true;
            this.username_exist.ForeColor = System.Drawing.Color.Red;
            this.username_exist.Location = new System.Drawing.Point(37, 13);
            this.username_exist.Name = "username_exist";
            this.username_exist.Size = new System.Drawing.Size(166, 13);
            this.username_exist.TabIndex = 5;
            this.username_exist.Text = "שם המשתמש כבר קיים במערכת";
            this.username_exist.Visible = false;
            // 
            // tooShort
            // 
            this.tooShort.AutoSize = true;
            this.tooShort.ForeColor = System.Drawing.Color.Red;
            this.tooShort.Location = new System.Drawing.Point(15, 53);
            this.tooShort.Name = "tooShort";
            this.tooShort.Size = new System.Drawing.Size(188, 13);
            this.tooShort.TabIndex = 5;
            this.tooShort.Text = "הזן סיסמא באורך של לפחות 6 תוים";
            this.tooShort.Visible = false;
            this.tooShort.Click += new System.EventHandler(this.tooShort_Click);
            // 
            // passwordvalidationtextbox
            // 
            this.passwordvalidationtextbox.Location = new System.Drawing.Point(232, 83);
            this.passwordvalidationtextbox.Name = "passwordvalidationtextbox";
            this.passwordvalidationtextbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordvalidationtextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordvalidationtextbox.TabIndex = 0;
            this.passwordvalidationtextbox.TextChanged += new System.EventHandler(this.password_validation_text_box);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "אימות סיסמא";
            // 
            // passwordvalidation
            // 
            this.passwordvalidation.AutoSize = true;
            this.passwordvalidation.ForeColor = System.Drawing.Color.Red;
            this.passwordvalidation.Location = new System.Drawing.Point(58, 90);
            this.passwordvalidation.Name = "passwordvalidation";
            this.passwordvalidation.Size = new System.Drawing.Size(145, 13);
            this.passwordvalidation.TabIndex = 5;
            this.passwordvalidation.Text = "הזן שנית את אותה הסיסמא";
            this.passwordvalidation.Visible = false;
            // 
            // InvalidMailLabel
            // 
            this.InvalidMailLabel.AutoSize = true;
            this.InvalidMailLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidMailLabel.Location = new System.Drawing.Point(58, 250);
            this.InvalidMailLabel.Name = "InvalidMailLabel";
            this.InvalidMailLabel.Size = new System.Drawing.Size(114, 13);
            this.InvalidMailLabel.TabIndex = 5;
            this.InvalidMailLabel.Text = "כתובת דוא\'\'ל שגוייה";
            this.InvalidMailLabel.Visible = false;
            // 
            // Admin_form_add_new_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 417);
            this.Controls.Add(this.InvalidMailLabel);
            this.Controls.Add(this.passwordvalidation);
            this.Controls.Add(this.tooShort);
            this.Controls.Add(this.username_exist);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.permission_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.passwordvalidationtextbox);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.usernamebox);
            this.MaximumSize = new System.Drawing.Size(448, 456);
            this.MinimumSize = new System.Drawing.Size(448, 456);
            this.Name = "Admin_form_add_new_user";
            this.Text = "הוספת משתמש חדש";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_form_add_new_user_FormClosed);
            this.Load += new System.EventHandler(this.Admin_form_add_new_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox permission_box;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Label username_exist;
        private System.Windows.Forms.Label tooShort;
        private System.Windows.Forms.TextBox passwordvalidationtextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label passwordvalidation;
        private System.Windows.Forms.Label InvalidMailLabel;
    }
}