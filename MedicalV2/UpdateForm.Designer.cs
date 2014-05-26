namespace MedicalV2
{
    partial class UpdateForm
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
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.ShowtabControl = new System.Windows.Forms.TabControl();
            this.PresentHistorytabPage = new System.Windows.Forms.TabPage();
            this.PhysicalInspecttabPage = new System.Windows.Forms.TabPage();
            this.CurePlantabPage = new System.Windows.Forms.TabPage();
            this.HosIDtextBox = new System.Windows.Forms.TextBox();
            this.HosIDLabel = new System.Windows.Forms.Label();
            this.ShowPanel = new System.Windows.Forms.Panel();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ShowtabControl.SuspendLayout();
            this.ShowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SuicideLabel
            // 
            this.SuicideLabel.AutoSize = true;
            this.SuicideLabel.Location = new System.Drawing.Point(435, 18);
            this.SuicideLabel.Name = "SuicideLabel";
            this.SuicideLabel.Size = new System.Drawing.Size(17, 12);
            this.SuicideLabel.TabIndex = 15;
            this.SuicideLabel.Text = "岁";
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(381, 14);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(37, 21);
            this.AgetextBox.TabIndex = 14;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(319, 18);
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
            this.TeletextBox.Location = new System.Drawing.Point(777, 15);
            this.TeletextBox.Name = "TeletextBox";
            this.TeletextBox.Size = new System.Drawing.Size(171, 21);
            this.TeletextBox.TabIndex = 26;
            // 
            // TeleLabel
            // 
            this.TeleLabel.AutoSize = true;
            this.TeleLabel.Location = new System.Drawing.Point(695, 18);
            this.TeleLabel.Name = "TeleLabel";
            this.TeleLabel.Size = new System.Drawing.Size(65, 12);
            this.TeleLabel.TabIndex = 25;
            this.TeleLabel.Text = "联系电话：";
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Location = new System.Drawing.Point(975, 620);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(126, 45);
            this.ShowAllBtn.TabIndex = 27;
            this.ShowAllBtn.Text = "显示全部";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // ShowtabControl
            // 
            this.ShowtabControl.Controls.Add(this.PresentHistorytabPage);
            this.ShowtabControl.Controls.Add(this.PhysicalInspecttabPage);
            this.ShowtabControl.Controls.Add(this.CurePlantabPage);
            this.ShowtabControl.Location = new System.Drawing.Point(9, 13);
            this.ShowtabControl.Name = "ShowtabControl";
            this.ShowtabControl.SelectedIndex = 0;
            this.ShowtabControl.Size = new System.Drawing.Size(1025, 487);
            this.ShowtabControl.TabIndex = 28;
            // 
            // PresentHistorytabPage
            // 
            this.PresentHistorytabPage.Location = new System.Drawing.Point(4, 22);
            this.PresentHistorytabPage.Name = "PresentHistorytabPage";
            this.PresentHistorytabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PresentHistorytabPage.Size = new System.Drawing.Size(1017, 461);
            this.PresentHistorytabPage.TabIndex = 0;
            this.PresentHistorytabPage.Text = "现病史";
            this.PresentHistorytabPage.UseVisualStyleBackColor = true;
            // 
            // PhysicalInspecttabPage
            // 
            this.PhysicalInspecttabPage.Location = new System.Drawing.Point(4, 22);
            this.PhysicalInspecttabPage.Name = "PhysicalInspecttabPage";
            this.PhysicalInspecttabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PhysicalInspecttabPage.Size = new System.Drawing.Size(1017, 461);
            this.PhysicalInspecttabPage.TabIndex = 1;
            this.PhysicalInspecttabPage.Text = "体格检查";
            this.PhysicalInspecttabPage.UseVisualStyleBackColor = true;
            // 
            // CurePlantabPage
            // 
            this.CurePlantabPage.Location = new System.Drawing.Point(4, 22);
            this.CurePlantabPage.Name = "CurePlantabPage";
            this.CurePlantabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CurePlantabPage.Size = new System.Drawing.Size(1017, 461);
            this.CurePlantabPage.TabIndex = 2;
            this.CurePlantabPage.Text = "治疗计划";
            this.CurePlantabPage.UseVisualStyleBackColor = true;
            // 
            // HosIDtextBox
            // 
            this.HosIDtextBox.Location = new System.Drawing.Point(547, 15);
            this.HosIDtextBox.Name = "HosIDtextBox";
            this.HosIDtextBox.Size = new System.Drawing.Size(118, 21);
            this.HosIDtextBox.TabIndex = 30;
            // 
            // HosIDLabel
            // 
            this.HosIDLabel.AutoSize = true;
            this.HosIDLabel.Location = new System.Drawing.Point(467, 18);
            this.HosIDLabel.Name = "HosIDLabel";
            this.HosIDLabel.Size = new System.Drawing.Size(53, 12);
            this.HosIDLabel.TabIndex = 29;
            this.HosIDLabel.Text = "门诊号：";
            // 
            // ShowPanel
            // 
            this.ShowPanel.Controls.Add(this.ShowtabControl);
            this.ShowPanel.Location = new System.Drawing.Point(3, 41);
            this.ShowPanel.Name = "ShowPanel";
            this.ShowPanel.Size = new System.Drawing.Size(1242, 573);
            this.ShowPanel.TabIndex = 31;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(1119, 620);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(126, 45);
            this.UpdateBtn.TabIndex = 33;
            this.UpdateBtn.Text = "更新";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 667);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ShowPanel);
            this.Controls.Add(this.HosIDtextBox);
            this.Controls.Add(this.HosIDLabel);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.TeletextBox);
            this.Controls.Add(this.TeleLabel);
            this.Controls.Add(this.SuicideLabel);
            this.Controls.Add(this.AgetextBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SexcomboBox);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.NaneLabel);
            this.Name = "UpdateForm";
            this.Text = "查询结果";
            this.ShowtabControl.ResumeLayout(false);
            this.ShowPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.TabControl ShowtabControl;
        private System.Windows.Forms.TabPage PresentHistorytabPage;
        private System.Windows.Forms.TabPage PhysicalInspecttabPage;
        private System.Windows.Forms.TabPage CurePlantabPage;
        private System.Windows.Forms.TextBox HosIDtextBox;
        private System.Windows.Forms.Label HosIDLabel;
        private System.Windows.Forms.Panel ShowPanel;
        private System.Windows.Forms.Button UpdateBtn;
    }
}