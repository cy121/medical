using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalV2
{
    public partial class CureFirst : Form
    {
        private String cfId;

        public CureFirst()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            cfId = string.Format("{0:yyyyMMddHHmm}", dt);
            this.Text = "初治" + cfId;
        }

        private void BasicInfogroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CureFirst_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicInfo basicinfo = new BasicInfo();
            basicinfo.Log_id = cfId.Trim();
            basicinfo.P_name = NametextBox.Text.Trim();
            if (SexcomboBox.Text.Trim().Equals("男"))
            {
                basicinfo.P_sex = '1';
            }
            else
            {
                basicinfo.P_sex = '0';
            }
            basicinfo.P_age = Convert.ToInt32(AgetextBox.Text.Trim());
            if (MarriedcomboBox.Text.Trim().Equals("是"))
            {
                basicinfo.P_married = '1';
            }
            else
            {
                basicinfo.P_married = '0';
            }
            basicinfo.P_radical = RadicaltextBox.Text.Trim();
            basicinfo.Hos_id = Convert.ToInt32(HosIDtextBox.Text.Trim());
            basicinfo.P_home = HometextBox.Text.Trim();
            basicinfo.P_born = BorntextBox.Text.Trim();
            basicinfo.P_jobaddr = JodaddrtextBox.Text.Trim();
            basicinfo.P_job = JobtextBox.Text.Trim();
            basicinfo.P_addr = HomeaddrtextBox.Text.Trim();
            basicinfo.P_tel = TeletextBox.Text.Trim();
            basicinfo.P_email = EmailtextBox.Text.Trim();
            basicinfo.P_contact = ContacttextBox.Text.Trim();
            basicinfo.P_relation = RelationtextBox.Text.Trim();

            basicinfo.insertBasicInfo();
        }
    }
}
