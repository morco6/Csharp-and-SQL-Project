namespace project___13
{
    partial class MenuTutor
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
            this.button1 = new System.Windows.Forms.Button();
            this.StudentEmailAdrees = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose an option:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Attendance List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.attendance_btn);
            // 
            // StudentEmailAdrees
            // 
            this.StudentEmailAdrees.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentEmailAdrees.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.StudentEmailAdrees.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StudentEmailAdrees.Location = new System.Drawing.Point(18, 190);
            this.StudentEmailAdrees.Name = "StudentEmailAdrees";
            this.StudentEmailAdrees.Size = new System.Drawing.Size(185, 50);
            this.StudentEmailAdrees.TabIndex = 3;
            this.StudentEmailAdrees.Text = "Student\'s email address";
            this.StudentEmailAdrees.UseVisualStyleBackColor = false;
            this.StudentEmailAdrees.Click += new System.EventHandler(this.studentsemails_btn);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(492, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Exit_btn);
            // 
            // MenuTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::project___13.Properties.Resources.רקע1;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.StudentEmailAdrees);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MenuTutor";
            this.Text = "MenuTutor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuTutor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StudentEmailAdrees;
        private System.Windows.Forms.Button button4;
    }
}