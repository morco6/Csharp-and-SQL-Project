namespace project___13
{
    partial class LecSearchListByID
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
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SerchB = new System.Windows.Forms.Button();
            this.StudentData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(123, 36);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(258, 20);
            this.IDTextBox.TabIndex = 0;
            this.IDTextBox.Text = "Enter ID";
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LabelID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search Student By ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SerchB
            // 
            this.SerchB.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.SerchB.Location = new System.Drawing.Point(392, 36);
            this.SerchB.Name = "SerchB";
            this.SerchB.Size = new System.Drawing.Size(75, 20);
            this.SerchB.TabIndex = 3;
            this.SerchB.Text = "Search";
            this.SerchB.UseVisualStyleBackColor = true;
            this.SerchB.Click += new System.EventHandler(this.SerchB_Click);
            // 
            // StudentData
            // 
            this.StudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentData.Location = new System.Drawing.Point(22, 78);
            this.StudentData.Name = "StudentData";
            this.StudentData.Size = new System.Drawing.Size(424, 150);
            this.StudentData.TabIndex = 4;
            this.StudentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentData_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button1.Location = new System.Drawing.Point(434, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecSearchListByID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project___13.Properties.Resources.רקע1;
            this.ClientSize = new System.Drawing.Size(521, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudentData);
            this.Controls.Add(this.SerchB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTextBox);
            this.Name = "LecSearchListByID";
            this.Text = "LecAttendanceListByID";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LecSearchListByID_FormClosed);
            this.Load += new System.EventHandler(this.LecAttendanceListByID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SerchB;
        private System.Windows.Forms.DataGridView StudentData;
        private System.Windows.Forms.Button button1;
    }
}