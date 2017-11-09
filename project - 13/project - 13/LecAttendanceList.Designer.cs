namespace project___13
{
    partial class LecAttendanceList
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
            this.constraintsComboBox = new System.Windows.Forms.ComboBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // constraintsComboBox
            // 
            this.constraintsComboBox.FormattingEnabled = true;
            this.constraintsComboBox.Location = new System.Drawing.Point(25, 27);
            this.constraintsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.constraintsComboBox.Name = "constraintsComboBox";
            this.constraintsComboBox.Size = new System.Drawing.Size(131, 21);
            this.constraintsComboBox.TabIndex = 0;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(160, 27);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(62, 21);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "SELECT";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Course: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 52);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(759, 199);
            this.dataGridView1.TabIndex = 3;
            // 
            // exite
            // 
            this.exite.Location = new System.Drawing.Point(706, 265);
            this.exite.Name = "exite";
            this.exite.Size = new System.Drawing.Size(75, 23);
            this.exite.TabIndex = 4;
            this.exite.Text = "Exit";
            this.exite.UseVisualStyleBackColor = true;
            this.exite.Click += new System.EventHandler(this.exite_Click);
            // 
            // LecAttendanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 300);
            this.Controls.Add(this.exite);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.constraintsComboBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LecAttendanceList";
            this.Text = "LecAttendanceList";
            this.Load += new System.EventHandler(this.LecAttendanceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox constraintsComboBox;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exite;
    }
}