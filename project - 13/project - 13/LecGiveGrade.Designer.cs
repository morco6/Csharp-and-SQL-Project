namespace project___13
{
    partial class LecGiveGrade
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
            this.ConstrainListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChose = new System.Windows.Forms.Label();
            this.Chosse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GradeBox = new System.Windows.Forms.TextBox();
            this.GradeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConstrainListBox
            // 
            this.ConstrainListBox.FormattingEnabled = true;
            this.ConstrainListBox.Location = new System.Drawing.Point(120, 56);
            this.ConstrainListBox.Name = "ConstrainListBox";
            this.ConstrainListBox.Size = new System.Drawing.Size(121, 21);
            this.ConstrainListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hey Lectturer choose course enter grade and click on student in the tabale.";
            // 
            // labelChose
            // 
            this.labelChose.AutoSize = true;
            this.labelChose.Location = new System.Drawing.Point(12, 59);
            this.labelChose.Name = "labelChose";
            this.labelChose.Size = new System.Drawing.Size(76, 13);
            this.labelChose.TabIndex = 2;
            this.labelChose.Text = "Chose Course:";
            // 
            // Chosse
            // 
            this.Chosse.Location = new System.Drawing.Point(263, 54);
            this.Chosse.Name = "Chosse";
            this.Chosse.Size = new System.Drawing.Size(101, 23);
            this.Chosse.TabIndex = 3;
            this.Chosse.Text = "Choose Course";
            this.Chosse.UseVisualStyleBackColor = true;
            this.Chosse.Click += new System.EventHandler(this.Chosse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // GradeBox
            // 
            this.GradeBox.Location = new System.Drawing.Point(426, 57);
            this.GradeBox.Name = "GradeBox";
            this.GradeBox.Size = new System.Drawing.Size(100, 20);
            this.GradeBox.TabIndex = 5;
            this.GradeBox.Text = "Enter grade";
            // 
            // GradeLabel
            // 
            this.GradeLabel.AutoSize = true;
            this.GradeLabel.Location = new System.Drawing.Point(381, 60);
            this.GradeLabel.Name = "GradeLabel";
            this.GradeLabel.Size = new System.Drawing.Size(39, 13);
            this.GradeLabel.TabIndex = 6;
            this.GradeLabel.Text = "Grade:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button1.Location = new System.Drawing.Point(538, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecGiveGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::project___13.Properties.Resources.רקע1;
            this.ClientSize = new System.Drawing.Size(628, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GradeLabel);
            this.Controls.Add(this.GradeBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Chosse);
            this.Controls.Add(this.labelChose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConstrainListBox);
            this.Name = "LecGiveGrade";
            this.Text = "LecGiveGrade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LecGiveGrade_FormClosed);
            this.Load += new System.EventHandler(this.LecGiveGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ConstrainListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChose;
        private System.Windows.Forms.Button Chosse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox GradeBox;
        private System.Windows.Forms.Label GradeLabel;
        private System.Windows.Forms.Button button1;
    }
}