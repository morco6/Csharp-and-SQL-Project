namespace project___13
{
    partial class SearchStudentScheduleStudentCoordinator
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
            this.Student = new System.Windows.Forms.ComboBox();
            this.labelS = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 0;
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
            // Student
            // 
            this.Student.FormattingEnabled = true;
            this.Student.Location = new System.Drawing.Point(81, 39);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(210, 21);
            this.Student.TabIndex = 2;
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(15, 42);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(44, 13);
            this.labelS.TabIndex = 3;
            this.labelS.Text = "Student";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(297, 37);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchStudentScheduleStudentCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SearchStudentScheduleStudentCoordinator";
            this.Text = "SearchStudentSchedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchStudentScheduleStudentCoordinator_FormClosed);
            this.Load += new System.EventHandler(this.SearchStudentScheduleStudentCoordinator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Student;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Button SearchBtn;
    }
}