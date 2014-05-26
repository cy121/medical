using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MedicalV2.Controls;

namespace MedicalV2
{
    public partial class UpdateForm : Form
    {
        private string id;

        public UpdateForm(String logId)
        {
            InitializeComponent();
            this.Text = "登记号：" + logId;
            BasicInfo bi = new BasicInfo();
            id = logId;
            bi.readBasicInfoById(logId);
            NametextBox.Text = bi.P_name;
            SexcomboBox.Text = Convert.ToString(bi.P_sex);
            AgetextBox.Text = Convert.ToString(bi.P_age);
            TeletextBox.Text = bi.P_tel;
            HosIDtextBox.Text = Convert.ToString(bi.Hos_id);
            Control phc = new PresentHistoryControl(id);
            Control pic = new PhysicalInspectControl(id);
            Control cpc = new CurePlanControl(id);
           
            this.PresentHistorytabPage.Controls.Add(phc);
            this.PhysicalInspecttabPage.Controls.Add(pic);
            this.CurePlantabPage.Controls.Add(cpc);
            
            
            foreach (Control control in Controls)
            {

                if (control is TextBox)
                {
                    TextBox tb = (TextBox)control;
                    tb.ReadOnly = true;
                }
                if (control is CheckBox)
                {
                    CheckBox cb = (CheckBox)control;
                    cb.Enabled = false;
                }
            }
        }

        private AllTabControl allTabControl;

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            this.ShowtabControl.Visible = false;
            allTabControl = new AllTabControl(id);
            this.ShowPanel.Controls.Add(allTabControl);
            //Control iic = new ImageInspectControl(id);
            //Control lic = new LabInspectControl(id);
            //Control chc = new ConstHistoryControl(id);
           //this.tabPage1.Controls.Add(iic);
           // this.tabPage2.Controls.Add(lic);
            //this.tabPage3.Controls.Add(chc);
            //new ShowAll().Show();
            this.ShowAllBtn.Visible = false;
            this.UpdateBtn.Visible = true;
            
        }

        

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            /***********************更新操作************************/
            allTabControl.Update();
        }

        

        
    }
}
