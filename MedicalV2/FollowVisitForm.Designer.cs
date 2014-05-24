namespace MedicalV2
{
    partial class FollowVisitForm
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
            this.SuicideLabel = new System.Windows.Forms.Label();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexcomboBox = new System.Windows.Forms.ComboBox();
            this.SexLabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.NaneLabel = new System.Windows.Forms.Label();
            this.TeletextBox = new System.Windows.Forms.TextBox();
            this.TeleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SuicideLabel
            // 
            this.SuicideLabel.AutoSize = true;
            this.SuicideLabel.Location = new System.Drawing.Point(448, 18);
            this.SuicideLabel.Name = "SuicideLabel";
            this.SuicideLabel.Size = new System.Drawing.Size(17, 12);
            this.SuicideLabel.TabIndex = 15;
            this.SuicideLabel.Text = "岁";
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(405, 15);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(37, 21);
            this.AgetextBox.TabIndex = 14;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(341, 18);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(41, 12);
            this.AgeLabel.TabIndex = 13;
            this.AgeLabel.Text = "年龄：";
            // 
            // SexcomboBox
            // 
            this.SexcomboBox.FormattingEnabled = true;
            this.SexcomboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.SexcomboBox.Location = new System.Drawing.Point(245, 15);
            this.SexcomboBox.Name = "SexcomboBox";
            this.SexcomboBox.Size = new System.Drawing.Size(52, 20);
            this.SexcomboBox.TabIndex = 12;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(181, 18);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(41, 12);
            this.SexLabel.TabIndex = 11;
            this.SexLabel.Text = "性别：";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(59, 14);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 21);
            this.NametextBox.TabIndex = 10;
            // 
            // NaneLabel
            // 
            this.NaneLabel.AutoSize = true;
            this.NaneLabel.Location = new System.Drawing.Point(12, 18);
            this.NaneLabel.Name = "NaneLabel";
            this.NaneLabel.Size = new System.Drawing.Size(41, 12);
            this.NaneLabel.TabIndex = 9;
            this.NaneLabel.Text = "姓名：";
            // 
            // TeletextBox
            // 
            this.TeletextBox.Location = new System.Drawing.Point(542, 15);
            this.TeletextBox.Name = "TeletextBox";
            this.TeletextBox.Size = new System.Drawing.Size(171, 21);
            this.TeletextBox.TabIndex = 26;
            // 
            // TeleLabel
            // 
            this.TeleLabel.AutoSize = true;
            this.TeleLabel.Location = new System.Drawing.Point(471, 18);
            this.TeleLabel.Name = "TeleLabel";
            this.TeleLabel.Size = new System.Drawing.Size(65, 12);
            this.TeleLabel.TabIndex = 25;
            this.TeleLabel.Text = "联系电话：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FollowVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TeletextBox);
            this.Controls.Add(this.TeleLabel);
            this.Controls.Add(this.SuicideLabel);
            this.Controls.Add(this.AgetextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SexcomboBox);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.NaneLabel);
            this.Name = "FollowVisitForm";
            this.Text = "随访";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SuicideLabel;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox SexcomboBox;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label NaneLabel;
        private System.Windows.Forms.TextBox TeletextBox;
        private System.Windows.Forms.Label TeleLabel;
        private System.Windows.Forms.Button button1;
    }
}