namespace project___13
{
    partial class LevSearchEmailByCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.constraintsComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(661, 199);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Course: ";
            // 
            // selectBtn
            // 
            this.selectBtn.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.selectBtn.Location = new System.Drawing.Point(145, 26);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(62, 21);
            this.selectBtn.TabIndex = 5;
            this.selectBtn.Text = "SELECT";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // constraintsComboBox
            // 
            this.constraintsComboBox.FormattingEnabled = true;
            this.constraintsComboBox.Location = new System.Drawing.Point(10, 26);
            this.constraintsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.constraintsComboBox.Name = "constraintsComboBox";
            this.constraintsComboBox.Size = new System.Drawing.Size(131, 21);
            this.constraintsComboBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button1.Location = new System.Drawing.Point(642, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LevSearchEmailByCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project___13.Properties.Resources.רקע1;
            this.ClientSize = new System.Drawing.Size(746, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.constraintsComboBox);
            this.Name = "LevSearchEmailByCourse";
            this.Text = "LevSearchEmailByCourse";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LevSearchEmailByCourse_FormClosed);
            this.Load += new System.EventHandler(this.LevSearchEmailByCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.ComboBox constraintsComboBox;
        private System.Windows.Forms.Button button1;
    }
}