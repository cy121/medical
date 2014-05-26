namespace MedicalV2
{
    partial class SearchUpdateForm
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
            this.LogIdTextBox = new System.Windows.Forms.TextBox();
            this.LogIdLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIdTextBox
            // 
            this.LogIdTextBox.Location = new System.Drawing.Point(139, 67);
            this.LogIdTextBox.Name = "LogIdTextBox";
            this.LogIdTextBox.Size = new System.Drawing.Size(150, 21);
            this.LogIdTextBox.TabIndex = 0;
            // 
            // LogIdLabel
            // 
            this.LogIdLabel.AutoSize = true;
            this.LogIdLabel.Location = new System.Drawing.Point(66, 70);
            this.LogIdLabel.Name = "LogIdLabel";
            this.LogIdLabel.Size = new System.Drawing.Size(41, 12);
            this.LogIdLabel.TabIndex = 1;
            this.LogIdLabel.Text = "登记号";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(139, 130);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 193);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.LogIdLabel);
            this.Controls.Add(this.LogIdTextBox);
            this.Name = "SearchForm";
            this.Text = "查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogIdTextBox;
        private System.Windows.Forms.Label LogIdLabel;
        private System.Windows.Forms.Button SearchBtn;
    }
}