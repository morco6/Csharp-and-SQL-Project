namespace project___13
{
    partial class StudentEmailAddressLecturer
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
            this.button1 = new System.Windows.Forms.Button();
            this.CourseBottun = new System.Windows.Forms.Button();
            this.nameBottun = new System.Windows.Forms.Button();
            this.IDBottun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(175, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exit_btn);
            // 
            // CourseBottun
            // 
            this.CourseBottun.Location = new System.Drawing.Point(11, 146);
            this.CourseBottun.Margin = new System.Windows.Forms.Padding(2);
            this.CourseBottun.Name = "CourseBottun";
            this.CourseBottun.Size = new System.Drawing.Size(133, 22);
            this.CourseBottun.TabIndex = 7;
            this.CourseBottun.Text = "By Course";
            this.CourseBottun.UseVisualStyleBackColor = true;
            this.CourseBottun.Click += new System.EventHandler(this.CourseBottun_Click);
            // 
            // nameBottun
            // 
            this.nameBottun.Location = new System.Drawing.Point(11, 102);
            this.nameBottun.Margin = new System.Windows.Forms.Padding(2);
            this.nameBottun.Name = "nameBottun";
            this.nameBottun.Size = new System.Drawing.Size(133, 22);
            this.nameBottun.TabIndex = 6;
            this.nameBottun.Text = "By Name";
            this.nameBottun.UseVisualStyleBackColor = true;
            this.nameBottun.Click += new System.EventHandler(this.nameBottun_Click);
            // 
            // IDBottun
            // 
            this.IDBottun.Location = new System.Drawing.Point(11, 60);
            this.IDBottun.Margin = new System.Windows.Forms.Padding(2);
            this.IDBottun.Name = "IDBottun";
            this.IDBottun.Size = new System.Drawing.Size(133, 22);
            this.IDBottun.TabIndex = 5;
            this.IDBottun.Text = "By ID";
            this.IDBottun.UseVisualStyleBackColor = true;
            this.IDBottun.Click += new System.EventHandler(this.IDBottun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select the type of search email\'s student:";
            // 
            // StudentEmailAddressLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.CourseBottun);
            this.Controls.Add(this.nameBottun);
            this.Controls.Add(this.IDBottun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "StudentEmailAddressLecturer";
            this.Text = "StudentEmailAddress";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentEmailAddressLecturer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CourseBottun;
        private System.Windows.Forms.Button nameBottun;
        private System.Windows.Forms.Button IDBottun;
        private System.Windows.Forms.Label label1;
    }
}