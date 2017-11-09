namespace project___13
{
    partial class SearchStudentsScheduleStudentCoordinator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EnterID_textbox = new System.Windows.Forms.TextBox();
            this.GetStudent_dataGridView = new System.Windows.Forms.DataGridView();
            this.searchID_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GetStudent_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(423, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exit_btn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the stusent\'s id :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EnterID_textbox
            // 
            this.EnterID_textbox.Location = new System.Drawing.Point(16, 50);
            this.EnterID_textbox.Name = "EnterID_textbox";
            this.EnterID_textbox.Size = new System.Drawing.Size(309, 20);
            this.EnterID_textbox.TabIndex = 3;
            this.EnterID_textbox.TextChanged += new System.EventHandler(this.EnterID_textbox_TextChanged);
            // 
            // GetStudent_dataGridView
            // 
            this.GetStudent_dataGridView.AllowUserToAddRows = false;
            this.GetStudent_dataGridView.AllowUserToDeleteRows = false;
            this.GetStudent_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GetStudent_dataGridView.Location = new System.Drawing.Point(16, 87);
            this.GetStudent_dataGridView.Name = "GetStudent_dataGridView";
            this.GetStudent_dataGridView.ReadOnly = true;
            this.GetStudent_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GetStudent_dataGridView.Size = new System.Drawing.Size(492, 76);
            this.GetStudent_dataGridView.TabIndex = 4;
            this.GetStudent_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetStudent_dataGridView_CellContentClick);
            // 
            // searchID_button
            // 
            this.searchID_button.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.searchID_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchID_button.Location = new System.Drawing.Point(415, 39);
            this.searchID_button.Name = "searchID_button";
            this.searchID_button.Size = new System.Drawing.Size(93, 31);
            this.searchID_button.TabIndex = 5;
            this.searchID_button.Text = "search";
            this.searchID_button.UseVisualStyleBackColor = true;
            this.searchID_button.Click += new System.EventHandler(this.searchID_button_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::project___13.Properties.Resources.רק_כפתור_נוסף;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(173, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit the student\'s schedule";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchStudentsScheduleStudentCoordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::project___13.Properties.Resources.רקע1;
            this.ClientSize = new System.Drawing.Size(520, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchID_button);
            this.Controls.Add(this.GetStudent_dataGridView);
            this.Controls.Add(this.EnterID_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SearchStudentsScheduleStudentCoordinator";
            this.Text = "EditStudentsSchedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditStudentsScheduleStudentCoordinator_FormClosed);
            this.Load += new System.EventHandler(this.EditStudentsScheduleStudentCoordinator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GetStudent_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnterID_textbox;
        private System.Windows.Forms.DataGridView GetStudent_dataGridView;
        private System.Windows.Forms.Button searchID_button;
        private System.Windows.Forms.Button button2;
    }
}