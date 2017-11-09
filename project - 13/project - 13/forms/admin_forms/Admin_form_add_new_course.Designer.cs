namespace project___13
{
    partial class Admin_form_add_new_course
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
            this.CourseName_box_content = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PointRight_combo_box = new System.Windows.Forms.ComboBox();
            this.HoursLecture_combo_box = new System.Windows.Forms.ComboBox();
            this.Year_combo_box = new System.Windows.Forms.ComboBox();
            this.Semester_combo_box = new System.Windows.Forms.ComboBox();
            this.HoursPractice_combo_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lsessionsbox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.psessionsbox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Precousecombox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CourseName_box_content
            // 
            this.CourseName_box_content.Location = new System.Drawing.Point(11, 13);
            this.CourseName_box_content.Name = "CourseName_box_content";
            this.CourseName_box_content.Size = new System.Drawing.Size(151, 20);
            this.CourseName_box_content.TabIndex = 0;
            this.CourseName_box_content.TextChanged += new System.EventHandler(this.CourseName_textbox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "שם הקורס";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "נקודות זכות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "שעות הרצאה שבועיות ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "שנה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "סמסטר";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "הוסף למאגר";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddToData_buttom);
            // 
            // PointRight_combo_box
            // 
            this.PointRight_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PointRight_combo_box.FormattingEnabled = true;
            this.PointRight_combo_box.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4",
            "4.5",
            "5",
            "5.5",
            "6"});
            this.PointRight_combo_box.Location = new System.Drawing.Point(11, 39);
            this.PointRight_combo_box.Name = "PointRight_combo_box";
            this.PointRight_combo_box.Size = new System.Drawing.Size(151, 21);
            this.PointRight_combo_box.TabIndex = 12;
            this.PointRight_combo_box.SelectedIndexChanged += new System.EventHandler(this.PointRight_combobox);
            // 
            // HoursLecture_combo_box
            // 
            this.HoursLecture_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursLecture_combo_box.FormattingEnabled = true;
            this.HoursLecture_combo_box.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.HoursLecture_combo_box.Location = new System.Drawing.Point(11, 65);
            this.HoursLecture_combo_box.Name = "HoursLecture_combo_box";
            this.HoursLecture_combo_box.Size = new System.Drawing.Size(151, 21);
            this.HoursLecture_combo_box.TabIndex = 13;
            this.HoursLecture_combo_box.SelectedIndexChanged += new System.EventHandler(this.HoursLecture_combobox);
            // 
            // Year_combo_box
            // 
            this.Year_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Year_combo_box.FormattingEnabled = true;
            this.Year_combo_box.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.Year_combo_box.Location = new System.Drawing.Point(11, 170);
            this.Year_combo_box.Name = "Year_combo_box";
            this.Year_combo_box.Size = new System.Drawing.Size(151, 21);
            this.Year_combo_box.TabIndex = 15;
            this.Year_combo_box.SelectedIndexChanged += new System.EventHandler(this.Year_combobox);
            // 
            // Semester_combo_box
            // 
            this.Semester_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Semester_combo_box.FormattingEnabled = true;
            this.Semester_combo_box.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.Semester_combo_box.Location = new System.Drawing.Point(11, 197);
            this.Semester_combo_box.Name = "Semester_combo_box";
            this.Semester_combo_box.Size = new System.Drawing.Size(151, 21);
            this.Semester_combo_box.TabIndex = 16;
            this.Semester_combo_box.SelectedIndexChanged += new System.EventHandler(this.Semester_combobox);
            // 
            // HoursPractice_combo_box
            // 
            this.HoursPractice_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursPractice_combo_box.FormattingEnabled = true;
            this.HoursPractice_combo_box.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.HoursPractice_combo_box.Location = new System.Drawing.Point(11, 91);
            this.HoursPractice_combo_box.Name = "HoursPractice_combo_box";
            this.HoursPractice_combo_box.Size = new System.Drawing.Size(151, 21);
            this.HoursPractice_combo_box.TabIndex = 18;
            this.HoursPractice_combo_box.SelectedIndexChanged += new System.EventHandler(this.HoursPractice_combobox);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "שעות תרגול שבועיות";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "מספר מפגשי הרצאה";
            // 
            // Lsessionsbox
            // 
            this.Lsessionsbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lsessionsbox.FormattingEnabled = true;
            this.Lsessionsbox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.Lsessionsbox.Location = new System.Drawing.Point(11, 117);
            this.Lsessionsbox.Name = "Lsessionsbox";
            this.Lsessionsbox.Size = new System.Drawing.Size(151, 21);
            this.Lsessionsbox.TabIndex = 13;
            this.Lsessionsbox.SelectedIndexChanged += new System.EventHandler(this.Lsessionsbox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "מספר מפגשי תרגול/מעבדה";
            // 
            // psessionsbox
            // 
            this.psessionsbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.psessionsbox.FormattingEnabled = true;
            this.psessionsbox.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.psessionsbox.Location = new System.Drawing.Point(11, 144);
            this.psessionsbox.Name = "psessionsbox";
            this.psessionsbox.Size = new System.Drawing.Size(151, 21);
            this.psessionsbox.TabIndex = 18;
            this.psessionsbox.SelectedIndexChanged += new System.EventHandler(this.psessionsbox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "קורס חובה";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "לא",
            "כן"});
            this.comboBox1.Location = new System.Drawing.Point(11, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "קורס קדם";
            // 
            // Precousecombox
            // 
            this.Precousecombox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Precousecombox.FormattingEnabled = true;
            this.Precousecombox.Items.AddRange(new object[] {
            "None"});
            this.Precousecombox.Location = new System.Drawing.Point(11, 250);
            this.Precousecombox.Name = "Precousecombox";
            this.Precousecombox.Size = new System.Drawing.Size(151, 21);
            this.Precousecombox.TabIndex = 16;
            this.Precousecombox.SelectedIndexChanged += new System.EventHandler(this.Precousecombox_SelectedIndexChanged);
            // 
            // Admin_form_add_new_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 394);
            this.Controls.Add(this.psessionsbox);
            this.Controls.Add(this.HoursPractice_combo_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Precousecombox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Semester_combo_box);
            this.Controls.Add(this.Year_combo_box);
            this.Controls.Add(this.Lsessionsbox);
            this.Controls.Add(this.HoursLecture_combo_box);
            this.Controls.Add(this.PointRight_combo_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CourseName_box_content);
            this.MaximumSize = new System.Drawing.Size(362, 433);
            this.MinimumSize = new System.Drawing.Size(362, 433);
            this.Name = "Admin_form_add_new_course";
            this.Text = "הוספת קורס למערכת";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_form_add_new_course_FormClosed);
            this.Load += new System.EventHandler(this.Admin_form_add_new_course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CourseName_box_content;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox PointRight_combo_box;
        private System.Windows.Forms.ComboBox HoursLecture_combo_box;
        private System.Windows.Forms.ComboBox Year_combo_box;
        private System.Windows.Forms.ComboBox Semester_combo_box;
        private System.Windows.Forms.ComboBox HoursPractice_combo_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Lsessionsbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox psessionsbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Precousecombox;
    }
}