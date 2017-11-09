namespace project___13
{
    partial class AttendanceListLecturer
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
            this.IDSerch = new System.Windows.Forms.Button();
            this.NameSerch = new System.Windows.Forms.Button();
            this.CourseSerch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello Lecturer!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // IDSerch
            // 
            this.IDSerch.Location = new System.Drawing.Point(12, 49);
            this.IDSerch.Name = "IDSerch";
            this.IDSerch.Size = new System.Drawing.Size(192, 42);
            this.IDSerch.TabIndex = 2;
            this.IDSerch.Text = "Serch Student By ID";
            this.IDSerch.UseVisualStyleBackColor = true;
            this.IDSerch.Click += new System.EventHandler(this.IDSerch_Click);
            // 
            // NameSerch
            // 
            this.NameSerch.Location = new System.Drawing.Point(12, 97);
            this.NameSerch.Name = "NameSerch";
            this.NameSerch.Size = new System.Drawing.Size(192, 42);
            this.NameSerch.TabIndex = 3;
            this.NameSerch.Text = "Serch Student By Name";
            this.NameSerch.UseVisualStyleBackColor = true;
            this.NameSerch.Click += new System.EventHandler(this.NameSerch_Click);
            // 
            // CourseSerch
            // 
            this.CourseSerch.Location = new System.Drawing.Point(12, 145);
            this.CourseSerch.Name = "CourseSerch";
            this.CourseSerch.Size = new System.Drawing.Size(192, 42);
            this.CourseSerch.TabIndex = 4;
            this.CourseSerch.Text = "Serch By Course";
            this.CourseSerch.UseVisualStyleBackColor = true;
            this.CourseSerch.Click += new System.EventHandler(this.CourseSerch_Click);
            // 
            // AttendanceListLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.CourseSerch);
            this.Controls.Add(this.NameSerch);
            this.Controls.Add(this.IDSerch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AttendanceListLecturer";
            this.Text = "AttendanceList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttendanceListLecturer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IDSerch;
        private System.Windows.Forms.Button NameSerch;
        private System.Windows.Forms.Button CourseSerch;
    }
}