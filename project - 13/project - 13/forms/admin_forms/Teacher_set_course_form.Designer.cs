namespace project___13.forms
{
    partial class Teacher_set_course_form
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
            this.courselist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addcourse = new System.Windows.Forms.Button();
            this.cancelll = new System.Windows.Forms.Button();
            this.courselist2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.courselist3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courselist
            // 
            this.courselist.FormattingEnabled = true;
            this.courselist.Location = new System.Drawing.Point(92, 12);
            this.courselist.Name = "courselist";
            this.courselist.Size = new System.Drawing.Size(121, 21);
            this.courselist.TabIndex = 0;
            this.courselist.SelectedIndexChanged += new System.EventHandler(this.courselist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "בחר מקצוע";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // addcourse
            // 
            this.addcourse.Enabled = false;
            this.addcourse.Location = new System.Drawing.Point(139, 141);
            this.addcourse.Name = "addcourse";
            this.addcourse.Size = new System.Drawing.Size(75, 23);
            this.addcourse.TabIndex = 2;
            this.addcourse.Text = "הוסף";
            this.addcourse.UseVisualStyleBackColor = true;
            this.addcourse.Click += new System.EventHandler(this.addcourse_Click);
            // 
            // cancelll
            // 
            this.cancelll.Location = new System.Drawing.Point(57, 141);
            this.cancelll.Name = "cancelll";
            this.cancelll.Size = new System.Drawing.Size(75, 23);
            this.cancelll.TabIndex = 2;
            this.cancelll.Text = "חזור";
            this.cancelll.UseVisualStyleBackColor = true;
            this.cancelll.Click += new System.EventHandler(this.cancelll_Click);
            // 
            // courselist2
            // 
            this.courselist2.Enabled = false;
            this.courselist2.FormattingEnabled = true;
            this.courselist2.Location = new System.Drawing.Point(92, 43);
            this.courselist2.Name = "courselist2";
            this.courselist2.Size = new System.Drawing.Size(121, 21);
            this.courselist2.TabIndex = 0;
            this.courselist2.SelectedIndexChanged += new System.EventHandler(this.courselist2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "בחר מקצוע";
            // 
            // courselist3
            // 
            this.courselist3.Enabled = false;
            this.courselist3.FormattingEnabled = true;
            this.courselist3.Location = new System.Drawing.Point(92, 74);
            this.courselist3.Name = "courselist3";
            this.courselist3.Size = new System.Drawing.Size(121, 21);
            this.courselist3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "בחר מקצוע";
            // 
            // Teacher_set_course_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 176);
            this.Controls.Add(this.cancelll);
            this.Controls.Add(this.addcourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.courselist3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.courselist2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courselist);
            this.MaximumSize = new System.Drawing.Size(307, 215);
            this.MinimumSize = new System.Drawing.Size(307, 215);
            this.Name = "Teacher_set_course_form";
            this.Text = "Teacher_set_course_form";
            this.Load += new System.EventHandler(this.Teacher_set_course_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox courselist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addcourse;
        private System.Windows.Forms.Button cancelll;
        private System.Windows.Forms.ComboBox courselist2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox courselist3;
        private System.Windows.Forms.Label label4;
    }
}