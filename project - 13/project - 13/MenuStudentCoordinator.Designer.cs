namespace project___13
{
    partial class MenuStudentCoordinator
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Back_To_Teachers_Sectery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(12, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search student\'s schedule";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(12, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 99);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit student\'s schedule";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.editStudentSchedule_btn);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Thistle;
            this.button3.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(209, 38);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 99);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search a student\'s Email address";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.searchEmailofStudent_btn);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Thistle;
            this.button4.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(401, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Exit_btn);
            // 
            // Back_To_Teachers_Sectery
            // 
            this.Back_To_Teachers_Sectery.BackColor = System.Drawing.Color.Thistle;
            this.Back_To_Teachers_Sectery.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.Back_To_Teachers_Sectery.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Back_To_Teachers_Sectery.Location = new System.Drawing.Point(209, 168);
            this.Back_To_Teachers_Sectery.Name = "Back_To_Teachers_Sectery";
            this.Back_To_Teachers_Sectery.Size = new System.Drawing.Size(151, 99);
            this.Back_To_Teachers_Sectery.TabIndex = 5;
            this.Back_To_Teachers_Sectery.Text = "Go back to teachers manegment";
            this.Back_To_Teachers_Sectery.UseVisualStyleBackColor = false;
            this.Back_To_Teachers_Sectery.Click += new System.EventHandler(this.Back_To_Teachers_Sectery_Click);
            // 
            // MenuStudentCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::project___13.Properties.Resources.רקע1;
            this.ClientSize = new System.Drawing.Size(543, 340);
            this.Controls.Add(this.Back_To_Teachers_Sectery);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MenuStudentCoordinator";
            this.Text = "MenuStudentCoordinator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuStudentCoordinator_FormClosed);
            this.Load += new System.EventHandler(this.MenuStudentCoordinator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Back_To_Teachers_Sectery;
    }
}