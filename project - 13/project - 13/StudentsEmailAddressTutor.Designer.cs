namespace project___13
{
    partial class StudentsEmailAddressTutor
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
            this.Exit = new System.Windows.Forms.Button();
            this.IDSearch = new System.Windows.Forms.Button();
            this.NameSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TatelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit.Location = new System.Drawing.Point(175, 210);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(85, 30);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_btn);
            // 
            // IDSearch
            // 
            this.IDSearch.Location = new System.Drawing.Point(12, 62);
            this.IDSearch.Name = "IDSearch";
            this.IDSearch.Size = new System.Drawing.Size(146, 23);
            this.IDSearch.TabIndex = 1;
            this.IDSearch.Text = "By ID";
            this.IDSearch.UseVisualStyleBackColor = true;
            this.IDSearch.Click += new System.EventHandler(this.IDSearch_Click);
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(12, 106);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(146, 23);
            this.NameSearch.TabIndex = 2;
            this.NameSearch.Text = "By Name";
            this.NameSearch.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "By Course";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TatelLabel
            // 
            this.TatelLabel.AutoSize = true;
            this.TatelLabel.Location = new System.Drawing.Point(13, 26);
            this.TatelLabel.Name = "TatelLabel";
            this.TatelLabel.Size = new System.Drawing.Size(110, 13);
            this.TatelLabel.TabIndex = 4;
            this.TatelLabel.Text = "Serch Student\'s Email";
            // 
            // StudentsEmailAddressTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.TatelLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.IDSearch);
            this.Controls.Add(this.Exit);
            this.Name = "StudentsEmailAddressTutor";
            this.Text = "StudentsEmailAddressTutor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentsEmailAddressTutor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button IDSearch;
        private System.Windows.Forms.Button NameSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label TatelLabel;
    }
}