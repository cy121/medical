namespace MedicalV2
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.FVIdLabel = new System.Windows.Forms.Label();
            this.FVIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(104, 151);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // FVIdLabel
            // 
            this.FVIdLabel.AutoSize = true;
            this.FVIdLabel.Location = new System.Drawing.Point(31, 91);
            this.FVIdLabel.Name = "FVIdLabel";
            this.FVIdLabel.Size = new System.Drawing.Size(65, 12);
            this.FVIdLabel.TabIndex = 4;
            this.FVIdLabel.Text = "随访病历号";
            // 
            // FVIdTextBox
            // 
            this.FVIdTextBox.Location = new System.Drawing.Point(104, 88);
            this.FVIdTextBox.Name = "FVIdTextBox";
            this.FVIdTextBox.Size = new System.Drawing.Size(150, 21);
            this.FVIdTextBox.TabIndex = 3;
            // 
            // SearchFollowVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.FVIdLabel);
            this.Controls.Add(this.FVIdTextBox);
            this.Name = "SearchFollowVisitForm";
            this.Text = "查询随访病历";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label FVIdLabel;
        private System.Windows.Forms.TextBox FVIdTextBox;
    }
}