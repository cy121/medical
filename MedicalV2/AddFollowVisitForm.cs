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
    public partial class AddFollowVisitForm : Form
    {
        private String cfId;
        private DateTime datetime;
        private string[] controlArr = {"NeckcheckBox",
                        "HeatcheckBox",
                        "IdrosischeckBox",
                        "FeeblecheckBox",
                        "WeightLcheckBox",
                        "WeightHcheckBox",
                        "ShakecheckBox",
                        "LanguagecheckBox",
                        "NervouscheckBox",
                        "InsomniacheckBox",
                        "AngrycheckBox",
                        "MemorycheckBox",
                        "IllusioncheckBox",
                        "DepressioncheckBox",
                        "ColdcheckBox",
                        "PalpitationcheckBox",
                        "ChestcheckBox",
                        "BreathcheckBox",
                        "PolyphagiacheckBox",
                        "HungercheckBox",
                        "AppetitecheckBox",
                        "JaundicecheckBox",
                        "NauseacheckBox",
                        "ExophthalmoscheckBox",
                        "EyecheckBox",
                        "SensationcheckBox",
                        "PhotophobiacheckBox",
                        "TearscheckBox",
                        "StackcheckBox",
                        "StackcheckBox",
                        "EyesightcheckBox",
                        "DiplopiacheckBox",
                        "StrabismuscheckBox",
                        "IrregularcheckBox",
                        "AmenorrhoeacheckBox",
                        "MammarycheckBox",
                        "ImpotencecheckBox",
                        "SexlesscheckBox",
                        "ZhoucheckBox",
                        "DiscomfortcheckBox",
                        "FlaccidcheckBox",
                        "DefecatecheckBox"}; 

        public AddFollowVisitForm()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            datetime = dt;
            cfId = string.Format("{0:yyyyMMddHHmm}", dt);
        }

        public AddFollowVisitForm(string id)
        {
            InitializeComponent();
            this.LabInspectpanel.Hide();
            this.PresentHistorygroupBox.Hide();
            PresentHistoryControl phc = new PresentHistoryControl(id);
            LabInspectControl lic = new LabInspectControl(id);
            this.PresentTabPage.Controls.Add(phc);
            this.LabInspecttabPage.Controls.Add(lic);
            BasicInfo bi = new BasicInfo();
            
            bi.readBasicInfoById(id);
            this.NametextBox.Text= bi.P_name;
            this.SexcomboBox.Text = Convert.ToString(bi.P_sex);
            this.AgetextBox.Text = Convert.ToString(bi.P_age);
            this.HosIDtextBox.Text = Convert.ToString(bi.Hos_id);
            this.TeletextBox.Text = bi.P_tel;
            
        }

        private void SaveFVBtn_Click(object sender, EventArgs e)
        {
            FollowVisit fv = new FollowVisit();
            PresentHistory ph = new PresentHistory();
            
            fv.Fv_id = cfId;
            fv.Log_id = cfId;

            fv.Fv_date = datetime.ToString();
            fv.Heavy_thing = this.HeavyTextBox.Text;
            fv.Light_thing = this.LightTextBox.Text;
            fv.Heart_rate = Convert.ToInt32(this.HeartRatetextBox.Text);

        }
    }
}
