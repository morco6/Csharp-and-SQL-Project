namespace project___13.forms.Secretary
{
    partial class Secretary_addremove_user
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
            this.Text_Label = new System.Windows.Forms.Label();
            this.FreeText = new System.Windows.Forms.TextBox();
            this.Preview_Button = new System.Windows.Forms.Button();
            this.Send_Button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title_Lable
            // 
            this.Title_Lable.AutoSize = true;
            this.Title_Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Lable.Location = new System.Drawing.Point(418, 19);
            this.Title_Lable.Name = "Title_Lable";
            this.Title_Lable.Size = new System.Drawing.Size(101, 20);
            this.Title_Lable.TabIndex = 0;
            this.Title_Lable.Text = "בקשה לאדמין";
            this.Title_Lable.Click += new System.EventHandler(this.Title_Lable_Click);
            // 
            // From_Label
            // 
            this.From_Label.AutoSize = true;
            this.From_Label.Location = new System.Drawing.Point(882, 74);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(38, 13);
            this.From_Label.TabIndex = 2;
            this.From_Label.Text = ":שולח";
            this.From_Label.Click += new System.EventHandler(this.From_Label_Click);
            // 
            // Sender_name_label
            // 
            this.Sender_name_label.AutoSize = true;
            this.Sender_name_label.Location = new System.Drawing.Point(642, 100);
            this.Sender_name_label.Name = "Sender_name_label";
            this.Sender_name_label.Size = new System.Drawing.Size(52, 13);
            this.Sender_name_label.TabIndex = 3;
            this.Sender_name_label.Text = "Secretery";
            this.Sender_name_label.Click += new System.EventHandler(this.Sender_name_label_Click);
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "הוסף משתמש",
            "הסר משתמש"});
            this.comboBox1.Location = new System.Drawing.Point(645, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(859, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = ":הוסף\\הסר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "!הכנס את פרטי המשתמש אל תוך הפירוט ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Secretary_addremove_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Send_Button);
            this.Controls.Add(this.Preview_Button);
            this.Controls.Add(this.FreeText);
            this.Controls.Add(this.Text_Label);
            this.Controls.Add(this.Sender_name_label);
            this.Controls.Add(this.From_Label);
            this.Controls.Add(this.Title_Lable);
            this.MaximumSize = new System.Drawing.Size(962, 400);
            this.MinimumSize = new System.Drawing.Size(962, 400);
            this.Name = "Secretary_addremove_user";
            this.Text = "הודעה חדשה";
            this.Load += new System.EventHandler(this.Form_teacher_asking_to_change_classroom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title_Lable;
        private System.Windows.Forms.Label From_Label;
        private System.Windows.Forms.Label Sender_name_label;
        private System.Windows.Forms.Label Text_Label;
        private System.Windows.Forms.TextBox FreeText;
        private System.Windows.Forms.Button Preview_Button;
        private System.Windows.Forms.Button Send_Button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}