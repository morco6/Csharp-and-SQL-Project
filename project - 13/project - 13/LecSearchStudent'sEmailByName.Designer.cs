namespace project___13
{
    partial class LecSearchStudent_sEmail
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
            this.Exit = new System.Windows.Forms.Button();
            this.SerchB = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.LastNameLibale = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.titelLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.Exit.Location = new System.Drawing.Point(559, 236);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SerchB
            // 
            this.SerchB.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.SerchB.Location = new System.Drawing.Point(482, 42);
            this.SerchB.Name = "SerchB";
            this.SerchB.Size = new System.Drawing.Size(75, 23);
            this.SerchB.TabIndex = 11;
            this.SerchB.Text = "Search";
            this.SerchB.UseVisualStyleBackColor = true;
            this.SerchB.Click += new System.EventHandler(this.SerchB_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(129, 62);
            this.LastName.Margin = new System.Windows.Forms.Padding(2);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(284, 20);
            this.LastName.TabIndex = 10;
            this.LastName.Text = "Last Name";
            // 
            // LastNameLibale
            // 
            this.LastNameLibale.AutoSize = true;
            this.LastNameLibale.Location = new System.Drawing.Point(17, 69);
            this.LastNameLibale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLibale.Name = "LastNameLibale";
            this.LastNameLibale.Size = new System.Drawing.Size(71, 13);
            this.LastNameLibale.TabIndex = 9;
            this.LastNameLibale.Text = "LAST NAME:";
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(129, 35);
            this.First_Name.Margin = new System.Windows.Forms.Padding(2);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(284, 20);
            this.First_Name.TabIndex = 8;
            this.First_Name.Text = "First Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(17, 42);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(75, 13);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "FIRST NAME:";
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Location = new System.Drawing.Point(12, 9);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(115, 13);
            this.titelLabel.TabIndex = 13;
            this.titelLabel.Text = "Search Email By Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 125);
            this.dataGridView1.TabIndex = 14;
            // 
            // LecSearchStudent_sEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::project___13.Properties.Resources.רקע1;
            this.ClientSize = new System.Drawing.Size(646, 271);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.titelLabel);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SerchB);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LastNameLibale);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "LecSearchStudent_sEmail";
            this.Text = "LecSearchStudent_sEmail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LecSearchStudent_sEmail_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SerchB;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label LastNameLibale;
        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}