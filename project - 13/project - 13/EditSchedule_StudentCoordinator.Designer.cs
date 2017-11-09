namespace project___13
{
    partial class EditSchedule_StudentCoordinator
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
            this.student_first_name = new System.Windows.Forms.Label();
            this.student_last_name = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.Label();
            this.student_year = new System.Windows.Forms.Label();
            this.get_first_name = new System.Windows.Forms.Label();
            this.lblget_first_name = new System.Windows.Forms.Label();
            this.lblget_last_name = new System.Windows.Forms.Label();
            this.lblget_ID = new System.Windows.Forms.Label();
            this.lblget_year = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1_courses_from_the_year = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2_courses_from_other_years = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3_courses_the_student_sigend_to = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1_lesson_this_year_course = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_courses_from_the_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_courses_from_other_years)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_courses_the_student_sigend_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_lesson_this_year_course)).BeginInit();
            this.SuspendLayout();
            // 
            // student_first_name
            // 
            this.student_first_name.AutoSize = true;
            this.student_first_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.student_first_name.Location = new System.Drawing.Point(12, 19);
            this.student_first_name.Name = "student_first_name";
            this.student_first_name.Size = new System.Drawing.Size(148, 18);
            this.student_first_name.TabIndex = 0;
            this.student_first_name.Text = "Student\'s first name:";
            this.student_first_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // student_last_name
            // 
            this.student_last_name.AutoSize = true;
            this.student_last_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.student_last_name.Location = new System.Drawing.Point(12, 52);
            this.student_last_name.Name = "student_last_name";
            this.student_last_name.Size = new System.Drawing.Size(147, 18);
            this.student_last_name.TabIndex = 1;
            this.student_last_name.Text = "Student\'s last name:";
            // 
            // student_id
            // 
            this.student_id.AutoSize = true;
            this.student_id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.student_id.Location = new System.Drawing.Point(302, 19);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(95, 18);
            this.student_id.TabIndex = 2;
            this.student_id.Text = "Student\'s ID:";
            // 
            // student_year
            // 
            this.student_year.AutoSize = true;
            this.student_year.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.student_year.Location = new System.Drawing.Point(302, 52);
            this.student_year.Name = "student_year";
            this.student_year.Size = new System.Drawing.Size(110, 18);
            this.student_year.TabIndex = 3;
            this.student_year.Text = "Student\'s year:";
            // 
            // get_first_name
            // 
            this.get_first_name.AutoSize = true;
            this.get_first_name.Location = new System.Drawing.Point(184, 17);
            this.get_first_name.Name = "get_first_name";
            this.get_first_name.Size = new System.Drawing.Size(0, 13);
            this.get_first_name.TabIndex = 4;
            // 
            // lblget_first_name
            // 
            this.lblget_first_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblget_first_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblget_first_name.ForeColor = System.Drawing.Color.DarkRed;
            this.lblget_first_name.Location = new System.Drawing.Point(166, 19);
            this.lblget_first_name.Name = "lblget_first_name";
            this.lblget_first_name.Size = new System.Drawing.Size(130, 18);
            this.lblget_first_name.TabIndex = 5;
            this.lblget_first_name.Click += new System.EventHandler(this.lblget_first_name_Click);
            // 
            // lblget_last_name
            // 
            this.lblget_last_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblget_last_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblget_last_name.ForeColor = System.Drawing.Color.DarkRed;
            this.lblget_last_name.Location = new System.Drawing.Point(166, 52);
            this.lblget_last_name.Name = "lblget_last_name";
            this.lblget_last_name.Size = new System.Drawing.Size(130, 18);
            this.lblget_last_name.TabIndex = 6;
            this.lblget_last_name.Click += new System.EventHandler(this.lblget_last_name_Click);
            // 
            // lblget_ID
            // 
            this.lblget_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblget_ID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblget_ID.ForeColor = System.Drawing.Color.DarkRed;
            this.lblget_ID.Location = new System.Drawing.Point(418, 19);
            this.lblget_ID.Name = "lblget_ID";
            this.lblget_ID.Size = new System.Drawing.Size(130, 18);
            this.lblget_ID.TabIndex = 7;
            this.lblget_ID.Click += new System.EventHandler(this.lblget_ID_Click);
            // 
            // lblget_year
            // 
            this.lblget_year.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblget_year.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblget_year.ForeColor = System.Drawing.Color.DarkRed;
            this.lblget_year.Location = new System.Drawing.Point(418, 52);
            this.lblget_year.Name = "lblget_year";
            this.lblget_year.Size = new System.Drawing.Size(130, 18);
            this.lblget_year.TabIndex = 8;
            this.lblget_year.Click += new System.EventHandler(this.lblget_year_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(15, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Courses from the student\'s year of studies:";
            // 
            // dataGridView1_courses_from_the_year
            // 
            this.dataGridView1_courses_from_the_year.AllowUserToAddRows = false;
            this.dataGridView1_courses_from_the_year.AllowUserToDeleteRows = false;
            this.dataGridView1_courses_from_the_year.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_courses_from_the_year.Location = new System.Drawing.Point(18, 113);
            this.dataGridView1_courses_from_the_year.Name = "dataGridView1_courses_from_the_year";
            this.dataGridView1_courses_from_the_year.ReadOnly = true;
            this.dataGridView1_courses_from_the_year.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_courses_from_the_year.Size = new System.Drawing.Size(637, 138);
            this.dataGridView1_courses_from_the_year.TabIndex = 10;
            this.dataGridView1_courses_from_the_year.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1_courses_from_the_year.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_courses_from_the_year_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(688, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Courses from other years:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2_courses_from_other_years
            // 
            this.dataGridView2_courses_from_other_years.AllowUserToAddRows = false;
            this.dataGridView2_courses_from_other_years.AllowUserToDeleteRows = false;
            this.dataGridView2_courses_from_other_years.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_courses_from_other_years.Location = new System.Drawing.Point(691, 113);
            this.dataGridView2_courses_from_other_years.Name = "dataGridView2_courses_from_other_years";
            this.dataGridView2_courses_from_other_years.ReadOnly = true;
            this.dataGridView2_courses_from_other_years.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2_courses_from_other_years.Size = new System.Drawing.Size(637, 138);
            this.dataGridView2_courses_from_other_years.TabIndex = 12;
            this.dataGridView2_courses_from_other_years.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_courses_from_other_years_CellContentClick);
            this.dataGridView2_courses_from_other_years.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_courses_from_other_years_CellMouseClick);
            this.dataGridView2_courses_from_other_years.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_courses_from_other_years_MouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(1228, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(15, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Courses that the student already signed up to:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView3_courses_the_student_sigend_to
            // 
            this.dataGridView3_courses_the_student_sigend_to.AllowUserToAddRows = false;
            this.dataGridView3_courses_the_student_sigend_to.AllowUserToDeleteRows = false;
            this.dataGridView3_courses_the_student_sigend_to.AllowUserToResizeColumns = false;
            this.dataGridView3_courses_the_student_sigend_to.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3_courses_the_student_sigend_to.Location = new System.Drawing.Point(15, 305);
            this.dataGridView3_courses_the_student_sigend_to.Name = "dataGridView3_courses_the_student_sigend_to";
            this.dataGridView3_courses_the_student_sigend_to.ReadOnly = true;
            this.dataGridView3_courses_the_student_sigend_to.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3_courses_the_student_sigend_to.Size = new System.Drawing.Size(637, 152);
            this.dataGridView3_courses_the_student_sigend_to.TabIndex = 15;
            this.dataGridView3_courses_the_student_sigend_to.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_courses_student_took_CellContentClick);
            this.dataGridView3_courses_the_student_sigend_to.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView3_courses_student_took_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(688, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lessons of the selected course:";
            // 
            // dataGridView1_lesson_this_year_course
            // 
            this.dataGridView1_lesson_this_year_course.AllowUserToAddRows = false;
            this.dataGridView1_lesson_this_year_course.AllowUserToDeleteRows = false;
            this.dataGridView1_lesson_this_year_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_lesson_this_year_course.Location = new System.Drawing.Point(691, 305);
            this.dataGridView1_lesson_this_year_course.Name = "dataGridView1_lesson_this_year_course";
            this.dataGridView1_lesson_this_year_course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_lesson_this_year_course.Size = new System.Drawing.Size(637, 152);
            this.dataGridView1_lesson_this_year_course.TabIndex = 18;
            this.dataGridView1_lesson_this_year_course.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_lesson_this_year_course_CellContentClick);
            this.dataGridView1_lesson_this_year_course.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_lesson_this_year_course_MouseClick);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(691, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 57);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add Student to Lesson";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(822, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 57);
            this.button3.TabIndex = 20;
            this.button3.Text = "Schedule";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button5.Location = new System.Drawing.Point(12, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 57);
            this.button5.TabIndex = 22;
            this.button5.Text = "Delete lesson";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EditSchedule_StudentCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project___13.Properties.Resources.רקע1;
            this.ClientSize = new System.Drawing.Size(1354, 546);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1_lesson_this_year_course);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3_courses_the_student_sigend_to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2_courses_from_other_years);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1_courses_from_the_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblget_year);
            this.Controls.Add(this.lblget_ID);
            this.Controls.Add(this.lblget_last_name);
            this.Controls.Add(this.lblget_first_name);
            this.Controls.Add(this.get_first_name);
            this.Controls.Add(this.student_year);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.student_last_name);
            this.Controls.Add(this.student_first_name);
            this.Name = "EditSchedule_StudentCoordinator";
            this.Text = "EditSchedule_StudentCoordinator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditSchedule_StudentCoordinator_FormClosed);
            this.Load += new System.EventHandler(this.EditSchedule_StudentCoordinator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_courses_from_the_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_courses_from_other_years)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3_courses_the_student_sigend_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_lesson_this_year_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label student_first_name;
        private System.Windows.Forms.Label student_last_name;
        private System.Windows.Forms.Label student_id;
        private System.Windows.Forms.Label student_year;
        private System.Windows.Forms.Label get_first_name;
        private System.Windows.Forms.Label lblget_first_name;
        private System.Windows.Forms.Label lblget_last_name;
        private System.Windows.Forms.Label lblget_ID;
        private System.Windows.Forms.Label lblget_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1_courses_from_the_year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2_courses_from_other_years;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3_courses_the_student_sigend_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1_lesson_this_year_course;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}