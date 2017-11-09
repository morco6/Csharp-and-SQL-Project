namespace project___13
{
    partial class StudentEditSchedule
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
            this.dataGridView1_courses_from_the_year = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1_lesson_this_year_course = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3_courses_the_student_sigend_to = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_courses_from_the_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_lesson_this_year_course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_courses_the_student_sigend_to)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit my schedule";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(1207, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exit_btn);
            // 
            // dataGridView1_courses_from_the_year
            // 
            this.dataGridView1_courses_from_the_year.AllowUserToAddRows = false;
            this.dataGridView1_courses_from_the_year.AllowUserToDeleteRows = false;
            this.dataGridView1_courses_from_the_year.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_courses_from_the_year.Location = new System.Drawing.Point(34, 98);
            this.dataGridView1_courses_from_the_year.Name = "dataGridView1_courses_from_the_year";
            this.dataGridView1_courses_from_the_year.ReadOnly = true;
            this.dataGridView1_courses_from_the_year.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_courses_from_the_year.Size = new System.Drawing.Size(637, 170);
            this.dataGridView1_courses_from_the_year.TabIndex = 11;
            this.dataGridView1_courses_from_the_year.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_courses_from_the_year_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Courses from my study year:";
            // 
            // dataGridView1_lesson_this_year_course
            // 
            this.dataGridView1_lesson_this_year_course.AllowUserToAddRows = false;
            this.dataGridView1_lesson_this_year_course.AllowUserToDeleteRows = false;
            this.dataGridView1_lesson_this_year_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_lesson_this_year_course.Location = new System.Drawing.Point(705, 98);
            this.dataGridView1_lesson_this_year_course.Name = "dataGridView1_lesson_this_year_course";
            this.dataGridView1_lesson_this_year_course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_lesson_this_year_course.Size = new System.Drawing.Size(637, 170);
            this.dataGridView1_lesson_this_year_course.TabIndex = 19;
            this.dataGridView1_lesson_this_year_course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_lesson_this_year_course_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(702, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Lessons of the selected course:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(705, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 57);
            this.button2.TabIndex = 21;
            this.button2.Text = "Register to Lesson";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView3_courses_the_student_sigend_to
            // 
            this.dataGridView3_courses_the_student_sigend_to.AllowUserToAddRows = false;
            this.dataGridView3_courses_the_student_sigend_to.AllowUserToDeleteRows = false;
            this.dataGridView3_courses_the_student_sigend_to.AllowUserToResizeColumns = false;
            this.dataGridView3_courses_the_student_sigend_to.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3_courses_the_student_sigend_to.Location = new System.Drawing.Point(34, 326);
            this.dataGridView3_courses_the_student_sigend_to.Name = "dataGridView3_courses_the_student_sigend_to";
            this.dataGridView3_courses_the_student_sigend_to.ReadOnly = true;
            this.dataGridView3_courses_the_student_sigend_to.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3_courses_the_student_sigend_to.Size = new System.Drawing.Size(637, 170);
            this.dataGridView3_courses_the_student_sigend_to.TabIndex = 22;
            this.dataGridView3_courses_the_student_sigend_to.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_courses_the_student_sigend_to_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(31, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Courses that the student already signed up to:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(34, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 57);
            this.button5.TabIndex = 24;
            this.button5.Text = "Delete lesson";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // StudentEditSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 592);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3_courses_the_student_sigend_to);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1_lesson_this_year_course);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1_courses_from_the_year);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "StudentEditSchedule";
            this.Text = "StudentEditSchedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentEditSchedule_FormClosed);
            this.Load += new System.EventHandler(this.StudentEditSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_courses_from_the_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_lesson_this_year_course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_courses_the_student_sigend_to)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1_courses_from_the_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1_lesson_this_year_course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView3_courses_the_student_sigend_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
    }
}