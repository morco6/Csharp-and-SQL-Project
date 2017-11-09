namespace project___13.forms
{
    partial class FeedClassesToSystemForm
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
            this.ClassName_ContentBox = new System.Windows.Forms.TextBox();
            this.ClassSeats_ContentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddClassButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassName_ContentBox
            // 
            this.ClassName_ContentBox.Location = new System.Drawing.Point(218, 39);
            this.ClassName_ContentBox.Name = "ClassName_ContentBox";
            this.ClassName_ContentBox.Size = new System.Drawing.Size(60, 20);
            this.ClassName_ContentBox.TabIndex = 2;
            this.ClassName_ContentBox.TextChanged += new System.EventHandler(this.ClassName_ContentBox_TextChanged);
            // 
            // ClassSeats_ContentBox
            // 
            this.ClassSeats_ContentBox.Location = new System.Drawing.Point(218, 65);
            this.ClassSeats_ContentBox.Name = "ClassSeats_ContentBox";
            this.ClassSeats_ContentBox.Size = new System.Drawing.Size(60, 20);
            this.ClassSeats_ContentBox.TabIndex = 3;
            this.ClassSeats_ContentBox.TextChanged += new System.EventHandler(this.ClassSeats_ContentBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(161, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "הכמות המינימלית היא 20 והמקסימית היא 100";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddClassButton
            // 
            this.AddClassButton.Location = new System.Drawing.Point(145, 150);
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(121, 23);
            this.AddClassButton.TabIndex = 5;
            this.AddClassButton.Text = "הוסף כיתה למאגר";
            this.AddClassButton.UseVisualStyleBackColor = true;
            this.AddClassButton.Click += new System.EventHandler(this.AddClassButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = ":שם כיתה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = ":מספר מקומות בכיתה";
            // 
            // FeedClassesToSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(413, 184);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddClassButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassSeats_ContentBox);
            this.Controls.Add(this.ClassName_ContentBox);
            this.MaximumSize = new System.Drawing.Size(429, 223);
            this.MinimumSize = new System.Drawing.Size(429, 223);
            this.Name = "FeedClassesToSystemForm";
            this.Text = "FeedClassesToSystemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FeedClassesToSystemForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ClassName_ContentBox;
        private System.Windows.Forms.TextBox ClassSeats_ContentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddClassButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}