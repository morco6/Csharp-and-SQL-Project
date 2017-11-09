namespace project___13
{
    partial class TutorSearchByName
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
            this.Students = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.SerchB = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Students)).BeginInit();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students.Location = new System.Drawing.Point(63, 123);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(371, 85);
            this.Students.TabIndex = 14;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(495, 226);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 13;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SerchB
            // 
            this.SerchB.Location = new System.Drawing.Point(240, 94);
            this.SerchB.Name = "SerchB";
            this.SerchB.Size = new System.Drawing.Size(75, 23);
            this.SerchB.TabIndex = 12;
            this.SerchB.Text = "Search";
            this.SerchB.UseVisualStyleBackColor = true;
            this.SerchB.Click += new System.EventHandler(this.SerchB_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(150, 69);
            this.LastName.Margin = new System.Windows.Forms.Padding(2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(284, 20);
            this.LastName.TabIndex = 11;
            this.LastName.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "LAST NAME:";
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(150, 42);
            this.First_Name.Margin = new System.Windows.Forms.Padding(2);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(284, 20);
            this.First_Name.TabIndex = 9;
            this.First_Name.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "FIRST NAME:";
            // 
            // TutorSearchByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(582, 261);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SerchB);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.label1);
            this.Name = "TutorSearchByName";
            this.Text = "TutorSearchByName";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TutorSearchByName_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Students;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SerchB;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.Label label1;
    }
}