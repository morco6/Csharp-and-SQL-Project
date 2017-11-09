namespace project___13.forms
{
    partial class SetNewPermissionForm
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
            this.choosePermission = new System.Windows.Forms.Label();
            this.PremissionComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choosePermission
            // 
            this.choosePermission.AutoSize = true;
            this.choosePermission.Location = new System.Drawing.Point(209, 9);
            this.choosePermission.Name = "choosePermission";
            this.choosePermission.Size = new System.Drawing.Size(67, 13);
            this.choosePermission.TabIndex = 0;
            this.choosePermission.Text = "בחר הרשאה";
            // 
            // PremissionComboBox
            // 
            this.PremissionComboBox.FormattingEnabled = true;
            this.PremissionComboBox.Items.AddRange(new object[] {
            "1-מזכירה",
            "2-מתרגל",
            "3-מרצה",
            "4-ראש מחלקה"});
            this.PremissionComboBox.Location = new System.Drawing.Point(82, 6);
            this.PremissionComboBox.Name = "PremissionComboBox";
            this.PremissionComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PremissionComboBox.Size = new System.Drawing.Size(121, 21);
            this.PremissionComboBox.TabIndex = 1;
            this.PremissionComboBox.SelectedIndexChanged += new System.EventHandler(this.PremissionComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שנה";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "חזור";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetNewPermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 91);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PremissionComboBox);
            this.Controls.Add(this.choosePermission);
            this.MaximumSize = new System.Drawing.Size(304, 130);
            this.MinimumSize = new System.Drawing.Size(304, 130);
            this.Name = "SetNewPermissionForm";
            this.Text = "SetNewPermissionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choosePermission;
        private System.Windows.Forms.ComboBox PremissionComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}