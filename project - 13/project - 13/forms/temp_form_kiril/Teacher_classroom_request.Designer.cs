namespace project___13.forms.temp_form_kiril
{
    partial class Teacher_classroom_request
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
            this.Title_Lable = new System.Windows.Forms.Label();
            this.From_Label = new System.Windows.Forms.Label();
            this.Sender_name_label = new System.Windows.Forms.Label();
            this.Subject_label = new System.Windows.Forms.Label();
            this.Subject_fixed_text = new System.Windows.Forms.Label();
            this.Text_Label = new System.Windows.Forms.Label();
            this.FreeText = new System.Windows.Forms.TextBox();
            this.Preview_Button = new System.Windows.Forms.Button();
            this.Send_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title_Lable
            // 
            this.Title_Lable.AutoSize = true;
            this.Title_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Lable.Location = new System.Drawing.Point(418, 19);
            this.Title_Lable.Name = "Title_Lable";
            this.Title_Lable.Size = new System.Drawing.Size(128, 20);
            this.Title_Lable.TabIndex = 0;
            this.Title_Lable.Text = "בקשה לשינוי כיתה";
            this.Title_Lable.Click += new System.EventHandler(this.Title_Lable_Click);
            // 
            // From_Label
            // 
            this.From_Label.AutoSize = true;
            this.From_Label.Location = new System.Drawing.Point(885, 57);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(38, 13);
            this.From_Label.TabIndex = 2;
            this.From_Label.Text = ":שולח";
            this.From_Label.Click += new System.EventHandler(this.From_Label_Click);
            // 
            // Sender_name_label
            // 
            this.Sender_name_label.AutoSize = true;
            this.Sender_name_label.Location = new System.Drawing.Point(645, 83);
            this.Sender_name_label.Name = "Sender_name_label";
            this.Sender_name_label.Size = new System.Drawing.Size(191, 13);
            this.Sender_name_label.TabIndex = 3;
            this.Sender_name_label.Text = "Sender teacher name last name TODO";
            this.Sender_name_label.Click += new System.EventHandler(this.Sender_name_label_Click);
            // 
            // Subject_label
            // 
            this.Subject_label.AutoSize = true;
            this.Subject_label.Location = new System.Drawing.Point(880, 122);
            this.Subject_label.Name = "Subject_label";
            this.Subject_label.Size = new System.Drawing.Size(43, 13);
            this.Subject_label.TabIndex = 5;
            this.Subject_label.Text = ":אילוץ";
            // 
            // Subject_fixed_text
            // 
            this.Subject_fixed_text.AutoSize = true;
            this.Subject_fixed_text.Location = new System.Drawing.Point(645, 153);
            this.Subject_fixed_text.Name = "Subject_fixed_text";
            this.Subject_fixed_text.Size = new System.Drawing.Size(345, 13);
            this.Subject_fixed_text.TabIndex = 6;
            this.Subject_fixed_text.Text = "[Teacher name] from [constrate] asking requesting to change classroom";
            this.Subject_fixed_text.Click += new System.EventHandler(this.Subject_fixed_text_Click);
            // 
            // Text_Label
            // 
            this.Text_Label.AutoSize = true;
            this.Text_Label.Location = new System.Drawing.Point(516, 57);
            this.Text_Label.Name = "Text_Label";
            this.Text_Label.Size = new System.Drawing.Size(40, 13);
            this.Text_Label.TabIndex = 7;
            this.Text_Label.Text = ":פירוט";
            this.Text_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // FreeText
            // 
            this.FreeText.Location = new System.Drawing.Point(39, 57);
            this.FreeText.Multiline = true;
            this.FreeText.Name = "FreeText";
            this.FreeText.Size = new System.Drawing.Size(454, 205);
            this.FreeText.TabIndex = 8;
            // 
            // Preview_Button
            // 
            this.Preview_Button.Location = new System.Drawing.Point(284, 283);
            this.Preview_Button.Name = "Preview_Button";
            this.Preview_Button.Size = new System.Drawing.Size(118, 41);
            this.Preview_Button.TabIndex = 9;
            this.Preview_Button.Text = "תצוגה מקדימה";
            this.Preview_Button.UseVisualStyleBackColor = true;
            this.Preview_Button.Click += new System.EventHandler(this.Preview_Button_Click);
            // 
            // Send_Button
            // 
            this.Send_Button.Location = new System.Drawing.Point(128, 283);
            this.Send_Button.Name = "Send_Button";
            this.Send_Button.Size = new System.Drawing.Size(118, 41);
            this.Send_Button.TabIndex = 10;
            this.Send_Button.Text = "שלח";
            this.Send_Button.UseVisualStyleBackColor = true;
            this.Send_Button.Click += new System.EventHandler(this.Send_Button_Click);
            // 
            // Teacher_classroom_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 361);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Preview_Button);
            this.Controls.Add(this.FreeText);
            this.Controls.Add(this.Text_Label);
            this.Controls.Add(this.Subject_fixed_text);
            this.Controls.Add(this.Subject_label);
            this.Controls.Add(this.Sender_name_label);
            this.Controls.Add(this.From_Label);
            this.Controls.Add(this.Title_Lable);
            this.Name = "Teacher_classroom_request";
            this.Text = "הודעה חדשה";
            this.Load += new System.EventHandler(this.Form_teacher_asking_to_change_classroom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Lable;
        private System.Windows.Forms.Label From_Label;
        private System.Windows.Forms.Label Sender_name_label;
        private System.Windows.Forms.Label Subject_label;
        private System.Windows.Forms.Label Subject_fixed_text;
        private System.Windows.Forms.Label Text_Label;
        private System.Windows.Forms.TextBox FreeText;
        private System.Windows.Forms.Button Preview_Button;
        private System.Windows.Forms.Button Send_Button;
    }
}