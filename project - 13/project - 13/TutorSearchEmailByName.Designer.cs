namespace project___13
{
    partial class TutorSearchEmailByName
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titelLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SerchB = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.LastNameLibale = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 125);
            this.dataGridView1.TabIndex = 23;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Location = new System.Drawing.Point(21, 11);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(115, 13);
            this.titelLabel.TabIndex = 22;
            this.titelLabel.Text = "Search Email By Name";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(567, 238);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 21;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SerchB
            // 
            this.SerchB.Location = new System.Drawing.Point(491, 44);
            this.SerchB.Name = "SerchB";
            this.SerchB.Size = new System.Drawing.Size(75, 23);
            this.SerchB.TabIndex = 20;
            this.SerchB.Text = "Search";
            this.SerchB.UseVisualStyleBackColor = true;
            this.SerchB.Click += new System.EventHandler(this.SerchB_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(138, 64);
            this.LastName.Margin = new System.Windows.Forms.Padding(2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(284, 20);
            this.LastName.TabIndex = 19;
            this.LastName.Text = "Last Name";
            // 
            // LastNameLibale
            // 
            this.LastNameLibale.AutoSize = true;
            this.LastNameLibale.Location = new System.Drawing.Point(26, 71);
            this.LastNameLibale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLibale.Name = "LastNameLibale";
            this.LastNameLibale.Size = new System.Drawing.Size(71, 13);
            this.LastNameLibale.TabIndex = 18;
            this.LastNameLibale.Text = "LAST NAME:";
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(138, 37);
            this.First_Name.Margin = new System.Windows.Forms.Padding(2);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(284, 20);
            this.First_Name.TabIndex = 17;
            this.First_Name.Text = "First Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(26, 44);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(75, 13);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "FIRST NAME:";
            // 
            // TutorSearchEmailByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 271);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SerchB);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LastNameLibale);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "TutorSearchEmailByName";
            this.Text = "TutorSearchEmailByName";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TutorSearchEmailByName_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SerchB;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label LastNameLibale;
        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.Label firstNameLabel;
    }
}