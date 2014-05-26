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
    public partial class FollowVisitForm : Form
    {
        private string id;

        public FollowVisitForm(String logId)
        {
            InitializeComponent();
            BasicInfo bi = new BasicInfo();
            id = logId;
            bi.readBasicInfoById(logId);
            NametextBox.Text = bi.P_name;
            SexcomboBox.Text = Convert.ToString(bi.P_sex);
            AgetextBox.Text = Convert.ToString(bi.P_age);
            TeletextBox.Text = bi.P_tel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control phc = new PresentHistoryControl(id);
            Control pic = new PhysicalInspectControl(id);
            Control cpc = new CurePlanControl(id);
            this.tabPage1.Controls.Add(phc);
            this.tabPage2.Controls.Add(pic);
            this.tabPage3.Controls.Add(cpc);

        }

        
    }
}
