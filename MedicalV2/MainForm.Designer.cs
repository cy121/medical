namespace MedicalV2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CureFirstBtn = new System.Windows.Forms.Button();
            this.SearchUpdateBtn = new System.Windows.Forms.Button();
            this.SearchFollowVisitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CureFirstBtn
            // 
            this.CureFirstBtn.Location = new System.Drawing.Point(142, 148);
            this.CureFirstBtn.Name = "CureFirstBtn";
            this.CureFirstBtn.Size = new System.Drawing.Size(119, 47);
            this.CureFirstBtn.TabIndex = 0;
            this.CureFirstBtn.Text = "初治";
            this.CureFirstBtn.UseVisualStyleBackColor = true;
            this.CureFirstBtn.Click += new System.EventHandler(this.CureFirstBtn_Click);
            // 
            // SearchUpdateBtn
            // 
            this.SearchUpdateBtn.Location = new System.Drawing.Point(421, 148);
            this.SearchUpdateBtn.Name = "SearchUpdateBtn";
            this.SearchUpdateBtn.Size = new System.Drawing.Size(119, 47);
            this.SearchUpdateBtn.TabIndex = 1;
            this.SearchUpdateBtn.Text = "复治";
            this.SearchUpdateBtn.UseVisualStyleBackColor = true;
            this.SearchUpdateBtn.Click += new System.EventHandler(this.RandomVisitBtn_Click);
            // 
            // SearchFollowVisitBtn
            // 
            this.SearchFollowVisitBtn.Location = new System.Drawing.Point(698, 148);
            this.SearchFollowVisitBtn.Name = "SearchFollowVisitBtn";
            this.SearchFollowVisitBtn.Size = new System.Drawing.Size(118, 47);
            this.SearchFollowVisitBtn.TabIndex = 2;
            this.SearchFollowVisitBtn.Text = "随访";
            this.SearchFollowVisitBtn.UseVisualStyleBackColor = true;
            this.SearchFollowVisitBtn.Click += new System.EventHandler(this.SearchFollowVisitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(978, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "                   Graves  甲  亢  病  历  管  理  系  统             ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(979, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchFollowVisitBtn);
            this.Controls.Add(this.SearchUpdateBtn);
            this.Controls.Add(this.CureFirstBtn);
            this.Name = "MainForm";
            this.Text = "病历系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CureFirstBtn;
        private System.Windows.Forms.Button SearchUpdateBtn;
        private System.Windows.Forms.Button SearchFollowVisitBtn;
        private System.Windows.Forms.Label label1;
    }
}