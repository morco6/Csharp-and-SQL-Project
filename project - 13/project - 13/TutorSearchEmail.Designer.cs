namespace project___13
{
    partial class TutorSearchEmail
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
            this.CourseSerch = new System.Windows.Forms.Button();
            this.NameSerch = new System.Windows.Forms.Button();
            this.IDSerch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ButnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseSerch
            // 
            this.CourseSerch.Location = new System.Drawing.Point(12, 145);
            this.CourseSerch.Name = "CourseSerch";
            this.CourseSerch.Size = new System.Drawing.Size(192, 42);
            this.CourseSerch.TabIndex = 13;
            this.CourseSerch.Text = "Serch Email By Course";
            this.CourseSerch.UseVisualStyleBackColor = true;
            this.CourseSerch.Click += new System.EventHandler(this.CourseSerch_Click);
            // 
            // NameSerch
            // 
            this.NameSerch.Location = new System.Drawing.Point(12, 97);
            this.NameSerch.Name = "NameSerch";
            this.NameSerch.Size = new System.Drawing.Size(192, 42);
            this.NameSerch.TabIndex = 12;
            this.NameSerch.Text = "Serch Email By Name";
            this.NameSerch.UseVisualStyleBackColor = true;
            this.NameSerch.Click += new System.EventHandler(this.NameSerch_Click);
            // 
            // IDSerch
            // 
            this.IDSerch.Location = new System.Drawing.Point(12, 49);
            this.IDSerch.Name = "IDSerch";
            this.IDSerch.Size = new System.Drawing.Size(192, 42);
            this.IDSerch.TabIndex = 11;
            this.IDSerch.Text = "Serch Email By ID";
            this.IDSerch.UseVisualStyleBackColor = true;
            this.IDSerch.Click += new System.EventHandler(this.IDSerch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hello Totur!";
            // 
            // ButnExit
            // 
            this.ButnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButnExit.Location = new System.Drawing.Point(449, 219);
            this.ButnExit.Name = "ButnExit";
            this.ButnExit.Size = new System.Drawing.Size(85, 30);
            this.ButnExit.TabIndex = 9;
            this.ButnExit.Text = "Exit";
            this.ButnExit.UseVisualStyleBackColor = false;
            this.ButnExit.Click += new System.EventHandler(this.ButnExit_Click);
            // 
            // TutorSearchEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.CourseSerch);
            this.Controls.Add(this.NameSerch);
            this.Controls.Add(this.IDSerch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButnExit);
            this.Name = "TutorSearchEmail";
            this.Text = "TutorSearchEmail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TutorSearchEmail_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CourseSerch;
        private System.Windows.Forms.Button NameSerch;
        private System.Windows.Forms.Button IDSerch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButnExit;
    }
}