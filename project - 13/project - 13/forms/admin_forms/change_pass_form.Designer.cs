namespace project___13
{
    partial class change_pass_form
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxPassToChange = new System.Windows.Forms.TextBox();
            this.tooShort = new System.Windows.Forms.Label();
            this.passwordvalidation = new System.Windows.Forms.Label();
            this.val_pass = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.change_pass_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox1.Location = new System.Drawing.Point(332, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "רשימת משתמשים";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox2.Location = new System.Drawing.Point(205, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "תבחר משתמש לשנות לו את הסיסמה";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox3.Location = new System.Drawing.Point(332, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "הזן סיסמה חדשה";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPassToChange
            // 
            this.textBoxPassToChange.Location = new System.Drawing.Point(205, 65);
            this.textBoxPassToChange.Name = "textBoxPassToChange";
            this.textBoxPassToChange.Size = new System.Drawing.Size(121, 20);
            this.textBoxPassToChange.TabIndex = 4;
            this.textBoxPassToChange.TextChanged += new System.EventHandler(this.pass_to_change);
            // 
            // tooShort
            // 
            this.tooShort.AutoSize = true;
            this.tooShort.ForeColor = System.Drawing.Color.Red;
            this.tooShort.Location = new System.Drawing.Point(12, 68);
            this.tooShort.Name = "tooShort";
            this.tooShort.Size = new System.Drawing.Size(188, 13);
            this.tooShort.TabIndex = 6;
            this.tooShort.Text = "הזן סיסמא באורך של לפחות 6 תוים";
            this.tooShort.Visible = false;
            // 
            // passwordvalidation
            // 
            this.passwordvalidation.AutoSize = true;
            this.passwordvalidation.ForeColor = System.Drawing.Color.Red;
            this.passwordvalidation.Location = new System.Drawing.Point(55, 92);
            this.passwordvalidation.Name = "passwordvalidation";
            this.passwordvalidation.Size = new System.Drawing.Size(145, 13);
            this.passwordvalidation.TabIndex = 7;
            this.passwordvalidation.Text = "הזן שנית את אותה הסיסמא";
            this.passwordvalidation.Visible = false;
            // 
            // val_pass
            // 
            this.val_pass.Location = new System.Drawing.Point(205, 89);
            this.val_pass.Name = "val_pass";
            this.val_pass.Size = new System.Drawing.Size(121, 20);
            this.val_pass.TabIndex = 9;
            this.val_pass.TextChanged += new System.EventHandler(this.val_pass_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Cornsilk;
            this.textBox5.Location = new System.Drawing.Point(332, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 20);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "אמת את הסיסמה";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // change_pass_button
            // 
            this.change_pass_button.BackColor = System.Drawing.Color.Cornsilk;
            this.change_pass_button.Location = new System.Drawing.Point(178, 140);
            this.change_pass_button.Name = "change_pass_button";
            this.change_pass_button.Size = new System.Drawing.Size(115, 35);
            this.change_pass_button.TabIndex = 10;
            this.change_pass_button.Text = "שנה סיסמה";
            this.change_pass_button.UseVisualStyleBackColor = false;
            this.change_pass_button.Click += new System.EventHandler(this.change_pass_button_Click);
            // 
            // change_pass_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(454, 182);
            this.Controls.Add(this.change_pass_button);
            this.Controls.Add(this.val_pass);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.passwordvalidation);
            this.Controls.Add(this.tooShort);
            this.Controls.Add(this.textBoxPassToChange);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.MaximumSize = new System.Drawing.Size(470, 221);
            this.MinimumSize = new System.Drawing.Size(470, 221);
            this.Name = "change_pass_form";
            this.Text = "Change Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.change_pass_form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxPassToChange;
        private System.Windows.Forms.Label tooShort;
        private System.Windows.Forms.Label passwordvalidation;
        private System.Windows.Forms.TextBox val_pass;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button change_pass_button;
    }
}