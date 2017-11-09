namespace project___13
{
    partial class LecStusent_sEmailAddress
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDBottun = new System.Windows.Forms.Button();
            this.nameBottun = new System.Windows.Forms.Button();
            this.CourseBottun = new System.Windows.Forms.Button();
            this.ExtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the type of search email\'s student:";
            // 
            // IDBottun
            // 
            this.IDBottun.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.IDBottun.Location = new System.Drawing.Point(11, 58);
            this.IDBottun.Margin = new System.Windows.Forms.Padding(2);
            this.IDBottun.Name = "IDBottun";
            this.IDBottun.Size = new System.Drawing.Size(133, 22);
            this.IDBottun.TabIndex = 1;
            this.IDBottun.Text = "By ID";
            this.IDBottun.UseVisualStyleBackColor = true;
            this.IDBottun.Click += new System.EventHandler(this.IDBottun_Click);
            // 
            // nameBottun
            // 
            this.nameBottun.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.nameBottun.Location = new System.Drawing.Point(11, 98);
            this.nameBottun.Margin = new System.Windows.Forms.Padding(2);
            this.nameBottun.Name = "nameBottun";
            this.nameBottun.Size = new System.Drawing.Size(133, 22);
            this.nameBottun.TabIndex = 2;
            this.nameBottun.Text = "By Name";
            this.nameBottun.UseVisualStyleBackColor = true;
            this.nameBottun.Click += new System.EventHandler(this.nameBottun_Click);
            // 
            // CourseBottun
            // 
            this.CourseBottun.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.CourseBottun.Location = new System.Drawing.Point(11, 138);
            this.CourseBottun.Margin = new System.Windows.Forms.Padding(2);
            this.CourseBottun.Name = "CourseBottun";
            this.CourseBottun.Size = new System.Drawing.Size(133, 22);
            this.CourseBottun.TabIndex = 3;
            this.CourseBottun.Text = "By Course";
            this.CourseBottun.UseVisualStyleBackColor = true;
            this.CourseBottun.Click += new System.EventHandler(this.button3_Click);
            // 
            // ExtButton
            // 
            this.ExtButton.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.ExtButton.Location = new System.Drawing.Point(336, 186);
            this.ExtButton.Name = "ExtButton";
            this.ExtButton.Size = new System.Drawing.Size(95, 23);
            this.ExtButton.TabIndex = 4;
            this.ExtButton.Text = "Exit";
            this.ExtButton.UseVisualStyleBackColor = true;
            this.ExtButton.Click += new System.EventHandler(this.ExtButton_Click);
            // 
            // LecStusent_sEmailAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project___13.Properties.Resources.רקע1;
            this.ClientSize = new System.Drawing.Size(443, 221);
            this.Controls.Add(this.ExtButton);
            this.Controls.Add(this.CourseBottun);
            this.Controls.Add(this.nameBottun);
            this.Controls.Add(this.IDBottun);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LecStusent_sEmailAddress";
            this.Text = "LecStusent_sEmailAddress";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LecStusent_sEmailAddress_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IDBottun;
        private System.Windows.Forms.Button nameBottun;
        private System.Windows.Forms.Button CourseBottun;
        private System.Windows.Forms.Button ExtButton;
    }
}