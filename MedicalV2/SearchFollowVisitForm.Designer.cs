﻿namespace MedicalV2
{
    partial class SearchFollowVisitForm
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
            this.FVSearchBtn = new System.Windows.Forms.Button();
            this.LogIdLabel = new System.Windows.Forms.Label();
            this.LogIdTextBox = new System.Windows.Forms.TextBox();
            this.AddFVBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FVSearchBtn
            // 
            this.FVSearchBtn.Location = new System.Drawing.Point(104, 151);
            this.FVSearchBtn.Name = "FVSearchBtn";
            this.FVSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.FVSearchBtn.TabIndex = 5;
            this.FVSearchBtn.Text = "查询";
            this.FVSearchBtn.UseVisualStyleBackColor = true;
            this.FVSearchBtn.Click += new System.EventHandler(this.FVSearchBtn_Click);
            // 
            // LogIdLabel
            // 
            this.LogIdLabel.AutoSize = true;
            this.LogIdLabel.Location = new System.Drawing.Point(31, 91);
            this.LogIdLabel.Name = "LogIdLabel";
            this.LogIdLabel.Size = new System.Drawing.Size(41, 12);
            this.LogIdLabel.TabIndex = 4;
            this.LogIdLabel.Text = "登记号";
            // 
            // LogIdTextBox
            // 
            this.LogIdTextBox.Location = new System.Drawing.Point(104, 88);
            this.LogIdTextBox.Name = "LogIdTextBox";
            this.LogIdTextBox.Size = new System.Drawing.Size(150, 21);
            this.LogIdTextBox.TabIndex = 3;
            // 
            // AddFVBtn
            // 
            this.AddFVBtn.Location = new System.Drawing.Point(104, 207);
            this.AddFVBtn.Name = "AddFVBtn";
            this.AddFVBtn.Size = new System.Drawing.Size(75, 23);
            this.AddFVBtn.TabIndex = 6;
            this.AddFVBtn.Text = "填写随访";
            this.AddFVBtn.UseVisualStyleBackColor = true;
            this.AddFVBtn.Click += new System.EventHandler(this.AddFVBtn_Click);
            // 
            // SearchFollowVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AddFVBtn);
            this.Controls.Add(this.FVSearchBtn);
            this.Controls.Add(this.LogIdLabel);
            this.Controls.Add(this.LogIdTextBox);
            this.Name = "SearchFollowVisitForm";
            this.Text = "查询随访病历";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FVSearchBtn;
        private System.Windows.Forms.Label LogIdLabel;
        private System.Windows.Forms.TextBox LogIdTextBox;
        private System.Windows.Forms.Button AddFVBtn;
    }
}