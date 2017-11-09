namespace project___13.forms.Teacher
{
    partial class declare_RP
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
            this.day_combox = new System.Windows.Forms.ComboBox();
            this.time_combox = new System.Windows.Forms.ComboBox();
            this.return_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // day_combox
            // 
            this.day_combox.FormattingEnabled = true;
            this.day_combox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.day_combox.Location = new System.Drawing.Point(29, 14);
            this.day_combox.Name = "day_combox";
            this.day_combox.Size = new System.Drawing.Size(58, 21);
            this.day_combox.TabIndex = 0;
            this.day_combox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // time_combox
            // 
            this.time_combox.FormattingEnabled = true;
            this.time_combox.Location = new System.Drawing.Point(29, 41);
            this.time_combox.Name = "time_combox";
            this.time_combox.Size = new System.Drawing.Size(58, 21);
            this.time_combox.TabIndex = 0;
            this.time_combox.SelectedIndexChanged += new System.EventHandler(this.time_combox_SelectedIndexChanged);
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(63, 98);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(75, 23);
            this.return_button.TabIndex = 1;
            this.return_button.Text = "חזרה";
            this.return_button.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.Enabled = false;
            this.ok_button.Location = new System.Drawing.Point(155, 98);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "אישור";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "יום";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "שעה";
            // 
            // declare_RP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 133);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.time_combox);
            this.Controls.Add(this.day_combox);
            this.Name = "declare_RP";
            this.Text = "declare_RP";
            this.Load += new System.EventHandler(this.declare_RP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox day_combox;
        private System.Windows.Forms.ComboBox time_combox;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}