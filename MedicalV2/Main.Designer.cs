namespace MedicalV2
{
    partial class Main
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
            this.CureFirstBtn = new System.Windows.Forms.Button();
            this.RandomVisitBtn = new System.Windows.Forms.Button();
            this.CureSecondBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CureFirstBtn
            // 
            this.CureFirstBtn.Location = new System.Drawing.Point(44, 71);
            this.CureFirstBtn.Name = "CureFirstBtn";
            this.CureFirstBtn.Size = new System.Drawing.Size(119, 47);
            this.CureFirstBtn.TabIndex = 0;
            this.CureFirstBtn.Text = "初治";
            this.CureFirstBtn.UseVisualStyleBackColor = true;
            this.CureFirstBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RandomVisitBtn
            // 
            this.RandomVisitBtn.Location = new System.Drawing.Point(185, 71);
            this.RandomVisitBtn.Name = "RandomVisitBtn";
            this.RandomVisitBtn.Size = new System.Drawing.Size(119, 47);
            this.RandomVisitBtn.TabIndex = 1;
            this.RandomVisitBtn.Text = "随访";
            this.RandomVisitBtn.UseVisualStyleBackColor = true;
            this.RandomVisitBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // CureSecondBtn
            // 
            this.CureSecondBtn.Location = new System.Drawing.Point(325, 71);
            this.CureSecondBtn.Name = "CureSecondBtn";
            this.CureSecondBtn.Size = new System.Drawing.Size(119, 47);
            this.CureSecondBtn.TabIndex = 2;
            this.CureSecondBtn.Text = "复治";
            this.CureSecondBtn.UseVisualStyleBackColor = true;
            this.CureSecondBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 199);
            this.Controls.Add(this.CureSecondBtn);
            this.Controls.Add(this.RandomVisitBtn);
            this.Controls.Add(this.CureFirstBtn);
            this.Name = "Main";
            this.Text = "病历系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CureFirstBtn;
        private System.Windows.Forms.Button RandomVisitBtn;
        private System.Windows.Forms.Button CureSecondBtn;
    }
}