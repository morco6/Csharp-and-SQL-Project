namespace project___13.forms
{
    partial class Teacher_add_courses_form
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
            this.cancelll = new System.Windows.Forms.Button();
            this.addcourse = new System.Windows.Forms.Button();
            this.courselist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelll
            // 
            this.cancelll.Location = new System.Drawing.Point(31, 79);
            this.cancelll.Name = "cancelll";
            this.cancelll.Size = new System.Drawing.Size(75, 23);
            this.cancelll.TabIndex = 5;
            this.cancelll.Text = "חזור";
            this.cancelll.UseVisualStyleBackColor = true;
            this.cancelll.Click += new System.EventHandler(this.cancelll_Click);
            // 
            // addcourse
            // 
            this.addcourse.Location = new System.Drawing.Point(113, 79);
            this.addcourse.Name = "addcourse";
            this.addcourse.Size = new System.Drawing.Size(75, 23);
            this.addcourse.TabIndex = 4;
            this.addcourse.Text = "הוסף";
            this.addcourse.UseVisualStyleBackColor = true;
            this.addcourse.Click += new System.EventHandler(this.addcourse_Click);
            // 
            // courselist
            // 
            this.courselist.FormattingEnabled = true;
            this.courselist.Location = new System.Drawing.Point(31, 12);
            this.courselist.Name = "courselist";
            this.courselist.Size = new System.Drawing.Size(121, 21);
            this.courselist.TabIndex = 3;
            this.courselist.SelectedIndexChanged += new System.EventHandler(this.courselist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "בחר מקצוע";
            // 
            // Teacher_add_courses_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 116);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelll);
            this.Controls.Add(this.addcourse);
            this.Controls.Add(this.courselist);
            this.MaximumSize = new System.Drawing.Size(257, 155);
            this.MinimumSize = new System.Drawing.Size(257, 155);
            this.Name = "Teacher_add_courses_form";
            this.Text = "Teacher_add_courses_form";
            this.Load += new System.EventHandler(this.Teacher_add_courses_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelll;
        private System.Windows.Forms.Button addcourse;
        private System.Windows.Forms.ComboBox courselist;
        private System.Windows.Forms.Label label1;
    }
}