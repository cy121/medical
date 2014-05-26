using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalV2.Controls
{
    public partial class AllTabControl : UserControl
    {
        private string logId;

        private string[] thyroidCheck = {"BigcheckBox",
                                "QuantityLesscheckBox",
                                "QuantityFormalcheckBox",
                                "QuantityMorecheckBox",
                                "DiffusiblecheckBox",
                                "TremblecheckBox",
                                "VesselcheckBox",
                                "NoduleNonecheckBox",
                                "NoduleLesscheckBox",
                                "NoduleMorecheckBox",
                                "PainNonecheckBox",
                                "PainLesscheckBox",
                                "PainMorecheckBox",
                                "LeftcheckBox",
                                "RightcheckBox",
                                "DissymmetrycheckBox"};

        private string[] heartCheck = {"HeartFormalcheckBox",
                                "HeartInformalcheckBox",
                                "HeartEarlycheckBox",
                                "NoiseNonecheckBox",
                                "NoiseHascheckBox",
                                "SystolecheckBox",
                                "DiastolecheckBox",
                                "BorderFormalcheckBox",
                                "BorderMorecheckBox",
                                "BreathClearcheckBox",
                                "BreathGancheckBox",
                                "BreathShicheckBox",
                                "LeftLungcheckBox",
                                "RightLungcheckBox" };

        private string[] eyeCheck = {"EyeTucheckBox",
                                    "FlashcheckBox",
                                    "FaceMorecheckBox",
                                    "EyelidLowcheckBox",
                                    "EyelidMorecheckBox",
                                    "ConjunctivacheckBox",
                                    "FullBloodcheckBox",
                                    "VoncheckBox",
                                    "JofforycheckBox",
                                    "MobiuscheckBox"};


        private string[] otherCheck = {"PachylosischeckBox",
                                "YellowcheckBox",
                                "SweetcheckBox",
                                "PointcheckBox",
                                "WatercheckBox",
                                "FaircheckBox" };


        private string[] etcCheck = { "ETCNodeNonecheckBox", "ETCNodeLesscheckBox", "ETCNodeMorecheckBox", "ETCLeftcheckBox", 
                                        "ETCRightcheckBox", "HotcheckBox", "WarmcheckBox", "ETCColdcheckBox"};

        private string[] bCheck = {"BNoduleNonecheckBox","BNoduleLesscheckBox","BNoduleMorecheckBox","BLeftcheckBox",
                                   "BRightcheckBox","BShiYongcheckBox","BNangcheckBox","BHuncheckBox"};

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
        private string[] efCheck = {"AgecheckBox",
                                "ZhengcheckBox",
                                "HecheckBox",
                                "BingcheckBox",
                                "shoushucheckBox",
                                "ATDcheckBox",
                                "fufacheckBox",
                                "JiacheckBox",
                                "JiejiecheckBox",
                                "qitacheckBox" };

        public AllTabControl()
        {
            InitializeComponent();
        }

        public AllTabControl(string id)
        {
            InitializeComponent();
            logId = id;
            /**************现病史***********/
            PresentHistory ph = new PresentHistory();
            ph.readPresentHistory(id);
            this.MainReporttextBox.Text = ph.Main_report;
            Char[] c = ph.Symptom.ToCharArray();
            int a = c.Length;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(controlArr[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }
            this.FlaccidtextBox.Text = Convert.ToString(ph.Palsy_times);
            this.DefecatetextBox.Text = Convert.ToString(ph.Stool_times);
            this.OthertextBox.Text = ph.Else_things;
            this.ProcessrichTextBox.Text = ph.Treat_process;



            /**************既往史***********/
            ConstHistory ch = new ConstHistory();
            ch.readConstHistory(id);
            PastrichTextBox.Text = ch.Past_his;
            Char[] personHis = ch.Person_his.ToCharArray();
            if (personHis[0] == 1)
                this.ResidentcheckBox.Checked = true;
            else if (personHis[1] == 1)
                this.EatSeacheckBox.Checked = true;
            else if (personHis[2] == 1)
                this.DrinkcheckBox.Checked = true;

            this.MarriAgetextBox.Text = Convert.ToString(ch.Mari_age);
            this.PregtextBox.Text = Convert.ToString(ch.Preg_times);
            this.BeartextBox.Text = Convert.ToString(ch.Bear_times);

            this.NatBeartextBox.Text = Convert.ToString(ch.Nat_bear);

            this.OpBeartextBox.Text = Convert.ToString(ch.Op_bear);
            this.NatAborttextBox.Text = Convert.ToString(ch.Nat_abort);
            this.OpAborttextBox.Text = Convert.ToString(ch.Op_abort);
            this.EarlyBeartextBox.Text = Convert.ToString(ch.Early_bear);
            this.DeadBeartextBox.Text = Convert.ToString(ch.Dead_bear);
            this.MenophaniaAgetextBox.Text = Convert.ToString(ch.Menophania_age);
            this.PeriodtextBox.Text = Convert.ToString(ch.Period);
            this.CycletextBox.Text = Convert.ToString(ch.Cycle_day);
            this.MenopauseYtextBox.Text = Convert.ToString(ch.Menopause_y);
            this.MenopauseMtextBox.Text = Convert.ToString(ch.Menopause_m);

            //经量
            if (ch.Bleed_amount == 0)
            {
                BleedFormalcheckBox.Checked = true;
            }

            else if (ch.Bleed_amount == 1)
            {
                BleedMorecheckBox.Checked = true; ;
            }

            else if (ch.Bleed_amount == 2)
            {
                BleedLesscheckBox.Checked = true;
            }

            //痛经
            if (ch.Meno_pain == 0)
            {
                MenoPainNonecheckBox.Checked = true;
            }
            else if (ch.Meno_pain == 1)
            {
                MenoPainHascheckBox.Checked = true;
            }

            //经期不规则
            if (ch.Meno_irregular == 0)
            {
                MenoIrregularNonecheckBox.Checked = true;
            }

            else if (ch.Meno_irregular == 1)
            {
                MenoIrregularHascheckBox.Checked = true;
            }





            /**************体格检查***********/
            PhysicalInspect pi = new PhysicalInspect();
            pi.readPhysicalInspect(id);
            Char[] thyroid = pi.Thyroid_inspect.ToCharArray();
            Char[] heart = pi.Heart_inspect.ToCharArray();
            Char[] eye = pi.Eye_inspect.ToCharArray();
            Char[] other = pi.Else_inspect.ToCharArray();
            for (int i = 0; i < thyroid.Length; i++)
            {
                if (thyroid[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(thyroidCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            for (int i = 0; i < heart.Length; i++)
            {
                if (heart[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(heartCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            for (int i = 0; i < eye.Length; i++)
            {
                if (eye[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(eyeCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(otherCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            this.BiggertextBox.Text = Convert.ToString(pi.Thyroid_bigger);
            this.LefttextBox.Text = Convert.ToString(pi.Thyroid_left);
            this.RighttextBox.Text = Convert.ToString(pi.Thyroid_right);
            this.HeartRatetextBox.Text = Convert.ToString(pi.Heart_rate);
            this.NoiseLeveltextBox.Text = Convert.ToString(pi.Noise_level);
            this.BloodLowtextBox.Text = Convert.ToString(pi.Blood_lpressure);
            this.BloodHightextBox.Text = Convert.ToString(pi.Blood_hpressure);
            this.EyeLefttextBox.Text = Convert.ToString(pi.Left_eye_out);
            this.EyeRighttextBox.Text = Convert.ToString(pi.Right_eye_out);
            this.EyeDistancetextBox.Text = Convert.ToString(pi.Eye_distance);

            /**************实验室检查***********/
            LabInspect li = new LabInspect();
            li.readLabInspect(id);
            FT3textBox.Text = Convert.ToString(li.Ft3);
            FT4textBox.Text = Convert.ToString(li.Ft4);
            TSHtextBox.Text = Convert.ToString(li.Tsh);
            TT3textBox.Text = Convert.ToString(li.Tt3);
            TT4textBox.Text = Convert.ToString(li.Tt4);
            TPOAbtextBox.Text = Convert.ToString(li.Tpoab);
            TgAbtextBox.Text = Convert.ToString(li.Tgab);
            TRAbtextBox.Text = Convert.ToString(li.Trab);
            WBCtextBox.Text = Convert.ToString(li.Wbc);
            RBCtextBox.Text = Convert.ToString(li.Rbc);
            HbtextBox.Text = Convert.ToString(li.Hb);
            PLTtextBox.Text = Convert.ToString(li.Plt);
            NLtextBox.Text = (li.N.Split('%'))[0];
            NRtextBox.Text = (li.N.Split('%'))[1];
            LLtextBox.Text = (li.L.Split('%'))[0];
            LRtextBox.Text = (li.L.Split('%'))[0];
            TBtextBox.Text = Convert.ToString(li.Tb);
            DBtextBox.Text = Convert.ToString(li.Db);
            ALTtextBox.Text = Convert.ToString(li.Alt);
            ASTtextBox.Text = Convert.ToString(li.Ast);
            ALPtextBox.Text = Convert.ToString(li.Alp);
            yGTtextBox.Text = Convert.ToString(li.Ygt);
            TPtextBox.Text = Convert.ToString(li.Tp);
            ALBtextBox.Text = Convert.ToString(li.Alb);
            GLOtextBox.Text = Convert.ToString(li.Glo);
            AGtextBox.Text = Convert.ToString(li.Ag);
            BUNtextBox.Text = Convert.ToString(li.Bun);
            UatextBox.Text = Convert.ToString(li.Ua);
            CRtextBox.Text = Convert.ToString(li.Cr);
            GLUtextBox.Text = Convert.ToString(li.Glu);
            SCtextBox.Text = Convert.ToString(li.Sc);
            KtextBox.Text = Convert.ToString(li.K);
            PtextBox.Text = Convert.ToString(li.P);
            ElseThingrichTextBox.Text = li.Else_inspect;

            /**************影像学检查***********/
            ImageInspect ii = new ImageInspect();
            ii.readImageInspect(id);
            this.ECGtextBox.Text = ii.Ecg;
            this.ETCleftLtextBox.Text = (ii.Ect_left.Split('×'))[0];
            this.ETCleftRtextBox.Text = (ii.Ect_left.Split('×'))[1];
            this.ETCRightLtextBox.Text = (ii.Ect_right.Split('×'))[0];
            this.ETCRightRtextBox.Text = (ii.Ect_right.Split('×'))[1];
            this.ETCAreatextBox.Text = Convert.ToString(ii.Ect_area);
            this.ETCTBtextBox.Text = Convert.ToString(ii.Ect_tb);
            this.ETCWeighttextBox.Text = Convert.ToString(ii.Ect_weight);
            Char[] etc = ii.Ect_inspect.ToCharArray();
            for (int i = 0; i < etc.Length; i++)
            {
                if (etc[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(etcCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }
            this.ETCNoduleLtextBox.Text = (ii.Ect_nodule.Split('×'))[0];
            this.ETCNoduleRtextBox.Text = (ii.Ect_nodule.Split('×'))[1];
            this.BLeftLtextBox.Text = (ii.B_left.Split('×'))[0];
            this.BLeftLtextBox.Text = (ii.B_left.Split('×'))[1];
            this.BRightLtextBox.Text = (ii.B_right.Split('×'))[0];
            this.BRightRtextBox.Text = (ii.B_right.Split('×'))[1];
            this.BAreatextBox.Text = Convert.ToString(ii.B_area);
            this.BWeighttextBox.Text = Convert.ToString(ii.B_weight);

            Char[] b = ii.B_inspect.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(bCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }

            this.BNoduleLtextBox.Text = (ii.B_nodule.Split('×'))[0];
            this.BNoduleRighttextBox.Text = (ii.B_nodule.Split('×'))[1];
            this.ElseJtextBox.Text = Convert.ToString(ii.Else_inspect);
            this.DiagnosisrichTextBox.Text = ii.Diagnosis;

            /**************治疗计划***********/

            CurePlan cp = new CurePlan();
            cp.readCurePlan(id);
            this.twohtextBox.Text = Convert.ToString(cp.Twoh_rate);
            this.TwoFhtextBox.Text = Convert.ToString(cp.Twentyfourh_rate);
            if (cp.Rate_level == 0)
            {
                NormalcheckBox.Checked = true;
            }

            if (cp.Rate_level == 1)
            {
                MorecheckBox.Checked = true;
            }

            if (cp.Rate_level == -1)
            {
                LesscheckBox.Checked = true;
            }
            this.RecomtextBox.Text = Convert.ToString(cp.Recom_dose);
            this.PlantextBox.Text = Convert.ToString(cp.Plan_dose);
            this.CaltextBox.Text = Convert.ToString(cp.Cal_dose);
            this.RealtextBox.Text = Convert.ToString(cp.Real_dose);
            Char[] ef = cp.Ef_factor.ToCharArray();
            for (int i = 0; i < ef.Length; i++)
            {
                if (ef[i] == '1')
                {
                    Control[] ctls = this.Controls.Find(efCheck[i], true);
                    if (ctls.Length > 0)
                    {
                        CheckBox cb = (CheckBox)ctls[0];
                        cb.Checked = true;
                    }

                }
            }
            this.ElsethingtextBox.Text = cp.Ef_else;
            this.elserichTextBox.Text = cp.Else_things;
            
        }

        public void Update()
        {
            


            /***********************************************************************************
         * 基本症状保存*
         ***********************************************************************************/
            PresentHistory presenthistory = new PresentHistory();
            presenthistory.Main_report = MainReporttextBox.Text.Trim();                  //主述
            presenthistory.Else_things = OthertextBox.Text.Trim();                       //其他
            char[] symptom = new char[50];
            if (NeckcheckBox.Checked) //颈粗
            {
                symptom[0] = '1';
            }
            else
            {
                symptom[0] = '0';
            }
            if (HeatcheckBox.Checked) //怕热
            {
                symptom[1] = '1';
            }
            else
            {
                symptom[1] = '0';
            }
            if (IdrosischeckBox.Checked) //多汗
            {
                symptom[2] = '1';
            }
            else
            {
                symptom[2] = '0';
            }
            if (FeeblecheckBox.Checked)  //乏力
            {
                symptom[3] = '1';
            }
            else
            {
                symptom[3] = '0';
            }
            if (WeightLcheckBox.Checked)  //体重减轻
            {
                symptom[4] = '1';
            }
            else
            {
                symptom[4] = '0';
            }
            if (WeightHcheckBox.Checked)  //体重增加
            {
                symptom[5] = '1';
            }
            else
            {
                symptom[5] = '0';
            }
            if (ShakecheckBox.Checked)  //手颤
            {
                symptom[6] = '1';
            }
            else
            {
                symptom[6] = '0';
            }
            if (LanguagecheckBox.Checked)  //多言多动
            {
                symptom[7] = '1';
            }
            else
            {
                symptom[7] = '0';
            }
            if (NervouscheckBox.Checked)  //紧张多虑
            {
                symptom[8] = '1';
            }
            else
            {
                symptom[8] = '0';
            }
            if (InsomniacheckBox.Checked)  //失眠
            {
                symptom[9] = '1';
            }
            else
            {
                symptom[9] = '0';
            }
            if (AngrycheckBox.Checked)  //焦躁易怒
            {
                symptom[10] = '1';
            }
            else
            {
                symptom[10] = '0';
            }
            if (MemorycheckBox.Checked)  //记忆力减退
            {
                symptom[11] = '1';
            }
            else
            {
                symptom[11] = '0';
            }
            if (IllusioncheckBox.Checked)  //幻觉
            {
                symptom[12] = '1';
            }
            else
            {
                symptom[12] = '0';
            }
            if (DepressioncheckBox.Checked)  //寡言抑郁
            {
                symptom[13] = '1';
            }
            else
            {
                symptom[13] = '0';
            }
            if (ColdcheckBox.Checked)  //神情冷漠
            {
                symptom[14] = '1';
            }
            else
            {
                symptom[14] = '0';
            }
            if (PalpitationcheckBox.Checked)  //心悸
            {
                symptom[15] = '1';
            }
            else
            {
                symptom[15] = '0';
            }
            if (ChestcheckBox.Checked)  //胸闷
            {
                symptom[16] = '1';
            }
            else
            {
                symptom[16] = '0';
            }
            if (BreathcheckBox.Checked)  //气短
            {
                symptom[17] = '1';
            }
            else
            {
                symptom[17] = '0';
            }
            if (PolyphagiacheckBox.Checked)  //多食
            {
                symptom[18] = '1';
            }
            else
            {
                symptom[18] = '0';
            }
            if (HungercheckBox.Checked)  //易饥
            {
                symptom[19] = '1';
            }
            else
            {
                symptom[19] = '0';
            }
            if (AppetitecheckBox.Checked)  //食欲减退
            {
                symptom[20] = '1';
            }
            else
            {
                symptom[20] = '0';
            }
            if (JaundicecheckBox.Checked)  //黄疸
            {
                symptom[21] = '1';
            }
            else
            {
                symptom[21] = '0';
            }
            if (NauseacheckBox.Checked)  //恶心呕吐
            {
                symptom[22] = '1';
            }
            else
            {
                symptom[22] = '0';
            }
            if (ExophthalmoscheckBox.Checked)  //突眼
            {
                symptom[23] = '1';
            }
            else
            {
                symptom[23] = '0';
            }
            if (EyecheckBox.Checked)  //眼胀
            {
                symptom[24] = '1';
            }
            else
            {
                symptom[24] = '0';
            }
            if (SensationcheckBox.Checked)  //眼异物感
            {
                symptom[25] = '1';
            }
            else
            {
                symptom[25] = '0';
            }
            if (PhotophobiacheckBox.Checked)  //怕光
            {
                symptom[26] = '1';
            }
            else
            {
                symptom[26] = '0';
            }
            if (TearscheckBox.Checked)  //流泪
            {
                symptom[27] = '1';
            }
            else
            {
                symptom[27] = '0';
            }
            if (StackcheckBox.Checked)  //刺痛
            {
                symptom[28] = '1';
            }
            else
            {
                symptom[28] = '0';
            }
            if (AsthenopiacheckBox.Checked)  //视力疲劳
            {
                symptom[29] = '1';
            }
            else
            {
                symptom[29] = '0';
            }
            if (EyesightcheckBox.Checked)  //视力减退
            {
                symptom[30] = '1';
            }
            else
            {
                symptom[30] = '0';
            }
            if (DiplopiacheckBox.Checked)  //复视
            {
                symptom[31] = '1';
            }
            else
            {
                symptom[31] = '0';
            }
            if (StrabismuscheckBox.Checked)  //斜视
            {
                symptom[32] = '1';
            }
            else
            {
                symptom[32] = '0';
            }
            if (IrregularcheckBox.Checked)  //月经不调
            {
                symptom[33] = '1';
            }
            else
            {
                symptom[33] = '0';
            }
            if (AmenorrhoeacheckBox.Checked)  //闭经
            {
                symptom[34] = '1';
            }
            else
            {
                symptom[34] = '0';
            }
            if (MammarycheckBox.Checked)  //乳腺增生
            {
                symptom[35] = '1';
            }
            else
            {
                symptom[35] = '0';
            }
            if (ImpotencecheckBox.Checked)  //阳痿
            {
                symptom[36] = '1';
            }
            else
            {
                symptom[36] = '0';
            }
            if (SexlesscheckBox.Checked)  //性冷淡
            {
                symptom[37] = '1';
            }
            else
            {
                symptom[37] = '0';
            }
            if (ZhoucheckBox.Checked)  //周麻
            {
                symptom[38] = '1';
            }
            else
            {
                symptom[38] = '0';
            }
            if (DiscomfortcheckBox.Checked)  //颈前不适
            {
                symptom[39] = '1';
            }
            else
            {
                symptom[39] = '0';
            }
            if (FlaccidcheckBox.Checked)  //软瘫
            {
                symptom[40] = '1';
                presenthistory.Palsy_times = Convert.ToInt32(FlaccidtextBox.Text.Trim());   //软瘫次数
            }
            else
            {
                symptom[40] = '0';
                presenthistory.Palsy_times = 0;   //软瘫次数
            }


            if (DefecatecheckBox.Checked)  //大便次数增多
            {
                symptom[41] = '1';
                presenthistory.Stool_times = Convert.ToInt32(DefecatetextBox.Text.Trim());   //大便次数
            }
            else
            {
                symptom[41] = '0';
                presenthistory.Stool_times = 0;   //大便次数
            }
            string symptom_string = new string(symptom);
            presenthistory.Symptom = symptom_string.Trim();  //症状
            presenthistory.Treat_process = ProcessrichTextBox.Text.Trim();      //发病及治疗经过

            /***********************************************************************************
            * 既往史保存*
            ***********************************************************************************/
            ConstHistory consthistory = new ConstHistory();
            /*既往史*/
            consthistory.Past_his = PastrichTextBox.Text.Trim();

            /*个人史*/
            char[] personhistory = new char[10];
            if (ResidentcheckBox.Checked)          //沿海地区居住10年以上
            {
                personhistory[0] = '1';
            }
            else
            {
                personhistory[0] = '0';
            }
            if (EatSeacheckBox.Checked)          //有食用海产品
            {
                personhistory[1] = '1';
            }
            else
            {
                personhistory[1] = '0';
            }
            if (DrinkcheckBox.Checked)          //饮凉茶的习惯
            {
                personhistory[2] = '1';
            }
            else
            {
                personhistory[2] = '0';
            }
            string person_his = new string(personhistory);
            consthistory.Person_his = person_his.Trim();


            /*婚育史*/
            consthistory.Mari_age = Convert.ToInt32(this.MarriAgetextBox.Text.Trim());  //结婚年龄
            consthistory.Preg_times = Convert.ToInt32(PregtextBox.Text.Trim());
            consthistory.Bear_times = Convert.ToInt32(BeartextBox.Text.Trim());
            consthistory.Nat_bear = Convert.ToInt32(NatBeartextBox.Text.Trim());
            consthistory.Op_abort = Convert.ToInt32(OpBeartextBox.Text.Trim());
            consthistory.Nat_abort = Convert.ToInt32(NatAborttextBox.Text.Trim());
            consthistory.Op_abort = Convert.ToInt32(OpAborttextBox.Text.Trim());
            consthistory.Early_bear = Convert.ToInt32(EarlyBeartextBox.Text.Trim());
            consthistory.Dead_bear = Convert.ToInt32(DeadBeartextBox.Text.Trim());


            /*月经史*/
            consthistory.Menophania_age = Convert.ToInt32(MenophaniaAgetextBox.Text.Trim());
            consthistory.Period = Convert.ToInt32(PeriodtextBox.Text.Trim());
            consthistory.Cycle_day = Convert.ToInt32(CycletextBox.Text.Trim());
            consthistory.Menopause_y = Convert.ToInt32(MenopauseYtextBox.Text.Trim());
            consthistory.Menopause_m = Convert.ToInt32(MenopauseMtextBox.Text.Trim());


            //经量
            if (BleedFormalcheckBox.Checked)
            {
                consthistory.Bleed_amount = 0;
            }

            if (BleedMorecheckBox.Checked)
            {
                consthistory.Bleed_amount = 1;
            }

            if (BleedLesscheckBox.Checked)
            {
                consthistory.Bleed_amount = 2;
            }

            //痛经
            if (MenoPainNonecheckBox.Checked)
            {
                consthistory.Meno_pain = 0;
            }
            if (MenoPainHascheckBox.Checked)
            {
                consthistory.Meno_pain = 1;
            }

            //经期不规则
            if (MenoIrregularNonecheckBox.Checked)
            {
                consthistory.Meno_irregular = 0;
            }

            if (MenoIrregularHascheckBox.Checked)
            {
                consthistory.Meno_irregular = 1;
            }


            /*家族史*/
            consthistory.Parent_his = ParentHisrichTextBox.Text.Trim();

            /****************************************************************
            * 体格检查保存*
            ****************************************************************/
            PhysicalInspect physical = new PhysicalInspect();

            /***************************
             * 甲状腺检查
             ***************************/

            physical.Thyroid_bigger = Convert.ToInt32(BiggertextBox.Text.Trim());
            physical.Thyroid_left = Convert.ToInt32(LefttextBox.Text.Trim());
            char[] thyroid = new char[16];
            if (BigcheckBox.Checked)
            {
                thyroid[0] = '1';
            }
            else
                thyroid[0] = '0';

            if (QuantityLesscheckBox.Checked)
            {
                thyroid[1] = '1';
            }
            else
                thyroid[1] = '0';

            if (QuantityFormalcheckBox.Checked)
            {
                thyroid[2] = '1';
            }
            else
                thyroid[2] = '0';

            if (QuantityMorecheckBox.Checked)
            {
                thyroid[3] = '1';
            }
            else
                thyroid[3] = '0';

            if (DiffusiblecheckBox.Checked)
            {
                thyroid[4] = '1';
            }
            else
                thyroid[4] = '0';

            if (TremblecheckBox.Checked)
            {
                thyroid[5] = '1';
            }
            else
                thyroid[5] = '0';

            if (VesselcheckBox.Checked)
            {
                thyroid[6] = '1';
            }
            else
                thyroid[6] = '0';

            if (NoduleNonecheckBox.Checked)
            {
                thyroid[7] = '1';
            }
            else
                thyroid[7] = '0';

            if (NoduleLesscheckBox.Checked)
            {
                thyroid[8] = '1';
            }
            else
                thyroid[8] = '0';

            if (NoduleMorecheckBox.Checked)
            {
                thyroid[9] = '1';
            }
            else
                thyroid[9] = '0';

            if (PainNonecheckBox.Checked)
            {
                thyroid[10] = '1';
            }
            else
                thyroid[10] = '0';

            if (PainLesscheckBox.Checked)
            {
                thyroid[11] = '1';
            }
            else
                thyroid[11] = '0';

            if (PainMorecheckBox.Checked)
            {
                thyroid[12] = '1';
            }
            else
                thyroid[12] = '0';

            if (LeftcheckBox.Checked)
            {
                thyroid[13] = '1';
            }
            else
                thyroid[13] = '0';

            if (RightcheckBox.Checked)
            {
                thyroid[14] = '1';
            }
            else
                thyroid[14] = '0';

            if (DissymmetrycheckBox.Checked)
            {
                thyroid[15] = '1';
            }
            else
                thyroid[15] = '0';

            string thyroidinspect = new string(thyroid);
            physical.Thyroid_inspect = thyroidinspect.Trim();


            /***********************************
             * 心血管肺
             **********************************/
            physical.Heart_rate = Convert.ToInt32(HeartRatetextBox.Text.Trim());
            physical.Noise_level = Convert.ToInt32(NoiseLeveltextBox.Text.Trim());
            physical.Blood_hpressure = Convert.ToInt32(BloodHightextBox.Text.Trim());
            physical.Blood_lpressure = Convert.ToInt32(BloodLowtextBox.Text.Trim());

            char[] heart = new char[14];
            if (HeartFormalcheckBox.Checked)
            {
                heart[0] = '1';
            }
            else
                heart[0] = '0';

            if (HeartInformalcheckBox.Checked)
            {
                heart[1] = '1';
            }
            else
                heart[1] = '0';

            if (HeartEarlycheckBox.Checked)
            {
                heart[2] = '1';
            }
            else
                heart[2] = '0';

            if (NoiseNonecheckBox.Checked)
            {
                heart[3] = '1';
            }
            else
                heart[3] = '0';

            if (NoiseHascheckBox.Checked)
            {
                heart[4] = '1';
            }
            else
                heart[4] = '0';

            if (SystolecheckBox.Checked)
            {
                heart[5] = '1';
            }
            else
                heart[5] = '0';

            if (DiastolecheckBox.Checked)
            {
                heart[6] = '1';
            }
            else
                heart[6] = '0';

            if (BorderFormalcheckBox.Checked)
            {
                heart[7] = '1';
            }
            else
                heart[7] = '0';

            if (BorderMorecheckBox.Checked)
            {
                heart[8] = '1';
            }
            else
                heart[8] = '0';

            if (BreathClearcheckBox.Checked)
            {
                heart[9] = '1';
            }
            else
                heart[9] = '0';

            if (BreathGancheckBox.Checked)
            {
                heart[10] = '1';
            }
            else
                heart[10] = '0';

            if (BreathShicheckBox.Checked)
            {
                heart[11] = '1';
            }
            else
                heart[11] = '0';

            if (LeftLungcheckBox.Checked)
            {
                heart[12] = '1';
            }
            else
                heart[12] = '0';

            if (RightLungcheckBox.Checked)
            {
                heart[13] = '1';
            }
            else
                heart[13] = '0';

            string heartispect = new string(heart);
            physical.Heart_inspect = heartispect.Trim();



            /*******************************
            * 眼征
            *********************************/
            physical.Left_eye_out = Convert.ToDouble(EyeLefttextBox.Text.Trim());
            physical.Right_eye_out = Convert.ToDouble(EyeRighttextBox.Text.Trim());
            physical.Eye_distance = Convert.ToDouble(EyeDistancetextBox.Text.Trim());

            char[] eye = new char[10];
            if (EyeTucheckBox.Checked)
            {
                eye[0] = '1';
            }
            else
                eye[0] = '0';

            if (FlashcheckBox.Checked)
            {
                eye[1] = '1';
            }
            else
                eye[1] = '0';

            if (FaceMorecheckBox.Checked)
            {
                eye[2] = '1';
            }
            else
                eye[2] = '0';

            if (EyelidLowcheckBox.Checked)
            {
                eye[3] = '1';
            }
            else
                eye[3] = '0';

            if (EyelidMorecheckBox.Checked)
            {
                eye[4] = '1';
            }
            else
                eye[4] = '0';

            if (ConjunctivacheckBox.Checked)
            {
                eye[5] = '1';
            }
            else
                eye[5] = '0';

            if (FullBloodcheckBox.Checked)
            {
                eye[6] = '1';
            }
            else
                eye[6] = '0';

            if (VoncheckBox.Checked)
            {
                eye[7] = '1';
            }
            else
                eye[7] = '0';

            if (JofforycheckBox.Checked)
            {
                eye[8] = '1';
            }
            else
                eye[8] = '0';

            if (MobiuscheckBox.Checked)
            {
                eye[9] = '1';
            }
            else
                eye[9] = '0';

            string eyeinspect = new string(eye);
            physical.Eye_inspect = eyeinspect.Trim();


            /**********************************
            * 其他
            ***********************************/
            char[] other = new char[6];
            if (PachylosischeckBox.Checked)
            {
                other[0] = '1';
            }
            else
                other[0] = '0';

            if (YellowcheckBox.Checked)
            {
                other[1] = '1';
            }
            else
                other[1] = '0';

            if (SweetcheckBox.Checked)
            {
                other[2] = '1';
            }
            else
                other[2] = '0';

            if (PointcheckBox.Checked)
            {
                other[3] = '1';
            }
            else
                other[3] = '0';

            if (WatercheckBox.Checked)
            {
                other[4] = '1';
            }
            else
                other[4] = '0';

            if (FaircheckBox.Checked)
            {
                other[5] = '1';
            }
            else
                other[5] = '0';

            string otherthing = new string(other);
            physical.Else_inspect = otherthing.Trim();


            /**********************************
            * 化验检查
            ***********************************/

            LabInspect labinspect = new LabInspect();
            labinspect.Ft3 = Convert.ToDouble(FT3textBox.Text.Trim());
            labinspect.Ft4 = Convert.ToDouble(FT4textBox.Text.Trim());
            labinspect.Tsh = Convert.ToDouble(TSHtextBox.Text.Trim());
            labinspect.Tt3 = Convert.ToDouble(TT3textBox.Text.Trim());
            labinspect.Tt4 = Convert.ToDouble(TT4textBox.Text.Trim());
            labinspect.Tpoab = Convert.ToDouble(TPOAbtextBox.Text.Trim());
            labinspect.Tgab = Convert.ToDouble(TgAbtextBox.Text.Trim());
            labinspect.Trab = Convert.ToDouble(TRAbtextBox.Text.Trim());
            labinspect.Wbc = Convert.ToDouble(WBCtextBox.Text.Trim());
            labinspect.Rbc = Convert.ToDouble(RBCtextBox.Text.Trim());
            labinspect.Hb = Convert.ToDouble(HbtextBox.Text.Trim());
            labinspect.Plt = Convert.ToDouble(PLTtextBox.Text.Trim());
            labinspect.N = NLtextBox.Text.Trim() + "%" + NRtextBox.Text.Trim();
            labinspect.L = LLtextBox.Text.Trim() + "%" + LRtextBox.Text.Trim();
            labinspect.Tb = Convert.ToDouble(TBtextBox.Text.Trim());
            labinspect.Db = Convert.ToDouble(DBtextBox.Text.Trim());
            labinspect.Alt = Convert.ToDouble(ALTtextBox.Text.Trim());
            labinspect.Ast = Convert.ToDouble(ASTtextBox.Text.Trim());
            labinspect.Alp = Convert.ToDouble(ALPtextBox.Text.Trim());
            labinspect.Ygt = Convert.ToDouble(yGTtextBox.Text.Trim());
            labinspect.Tp = Convert.ToDouble(TPtextBox.Text.Trim());
            labinspect.Alb = Convert.ToDouble(ALBtextBox.Text.Trim());
            labinspect.Glo = Convert.ToDouble(GLOtextBox.Text.Trim());
            labinspect.Ag = Convert.ToDouble(AGtextBox.Text.Trim());
            labinspect.Bun = Convert.ToDouble(BUNtextBox.Text.Trim());
            labinspect.Ua = Convert.ToDouble(UatextBox.Text.Trim());
            labinspect.Cr = Convert.ToDouble(CRtextBox.Text.Trim());
            labinspect.Glu = Convert.ToDouble(GLUtextBox.Text.Trim());
            labinspect.Sc = Convert.ToDouble(SCtextBox.Text.Trim());
            labinspect.K = Convert.ToDouble(KtextBox.Text.Trim());
            labinspect.P = Convert.ToDouble(PtextBox.Text.Trim());
            labinspect.Else_inspect = ElseThingrichTextBox.Text.Trim();

            /**********************************
           * 影像学
           ***********************************/

            ImageInspect imageinspect = new ImageInspect();
            imageinspect.Ecg = ECGtextBox.Text.Trim();
            imageinspect.Ect_left = ETCleftLtextBox.Text.Trim() + "×" + ETCleftRtextBox.Text.Trim();
            imageinspect.Ect_right = ETCRightLtextBox.Text.Trim() + "×" + ETCRightRtextBox.Text.Trim();
            imageinspect.Ect_area = Convert.ToDouble(ETCAreatextBox.Text.Trim());
            imageinspect.Ect_tb = Convert.ToDouble(ETCTBtextBox.Text.Trim());
            imageinspect.Ect_weight = Convert.ToDouble(ETCWeighttextBox.Text.Trim());
            imageinspect.Ect_nodule = ETCNoduleLtextBox.Text.Trim() + "×" + ETCNoduleRtextBox.Text.Trim();
            char[] etc = new char[8];
            if (ETCNodeNonecheckBox.Checked)
            {
                etc[0] = '1';
            }
            else
                etc[0] = '0';

            if (ETCNodeLesscheckBox.Checked)
            {
                etc[1] = '1';
            }
            else
                etc[1] = '0';

            if (ETCNodeMorecheckBox.Checked)
            {
                etc[2] = '1';
            }
            else
                etc[2] = '0';

            if (ETCLeftcheckBox.Checked)
            {
                etc[3] = '1';
            }
            else
                etc[3] = '0';

            if (ETCRightcheckBox.Checked)
            {
                etc[4] = '1';
            }
            else
                etc[4] = '0';

            if (HotcheckBox.Checked)
            {
                etc[5] = '1';
            }
            else
                etc[5] = '0';

            if (WarmcheckBox.Checked)
            {
                etc[6] = '1';
            }
            else
                etc[6] = '0';

            if (ETCColdcheckBox.Checked)
            {
                etc[7] = '1';
            }
            else
                etc[7] = '0';

            string etcinspect = new string(etc);
            imageinspect.Ect_inspect = etcinspect;
            imageinspect.B_left = Convert.ToString(BLeftLtextBox.Text.Trim()) + "×" + Convert.ToString(BLeftRtextBox.Text.Trim());
            imageinspect.B_right = Convert.ToString(BRightLtextBox.Text.Trim()) + "×" + Convert.ToString(BRightRtextBox.Text.Trim());
            imageinspect.B_area = Convert.ToDouble(BAreatextBox.Text.Trim());
            imageinspect.B_weight = Convert.ToDouble(BWeighttextBox.Text.Trim());
            imageinspect.B_nodule = Convert.ToString(BNoduleLtextBox.Text.Trim()) + "×" + Convert.ToString(BNoduleRighttextBox.Text.Trim());


            char[] b = new char[8];
            if (BNoduleNonecheckBox.Checked)
            {
                b[0] = '1';
            }
            else
                b[0] = '0';

            if (BNoduleLesscheckBox.Checked)
            {
                b[1] = '1';
            }
            else
                b[1] = '0';

            if (BNoduleMorecheckBox.Checked)
            {
                b[2] = '1';
            }
            else
                b[2] = '0';

            if (BLeftcheckBox.Checked)
            {
                b[3] = '1';
            }
            else
                b[3] = '0';

            if (BRightcheckBox.Checked)
            {
                b[4] = '1';
            }
            else
                b[4] = '0';

            if (BShiYongcheckBox.Checked)
            {
                b[5] = '1';
            }
            else
                b[5] = '0';

            if (BNangcheckBox.Checked)
            {
                b[6] = '1';
            }
            else
                b[6] = '0';

            if (BHuncheckBox.Checked)
            {
                b[7] = '1';
            }
            else
                b[7] = '0';

            string binspect = new string(b);
            imageinspect.B_inspect = binspect;
            imageinspect.Else_inspect = Convert.ToDouble(ElseJtextBox.Text.Trim());
            imageinspect.Diagnosis = DiagnosisrichTextBox.Text.Trim();

            /**********************************
           * 治疗计划
           ***********************************/

            CurePlan cureplan = new CurePlan();
            cureplan.Twoh_rate = Convert.ToDouble(twohtextBox.Text.Trim());
            cureplan.Twentyfourh_rate = Convert.ToDouble(TwoFhtextBox.Text.Trim());
            if (NormalcheckBox.Checked)
            {
                cureplan.Rate_level = 0;
            }

            if (MorecheckBox.Checked)
            {
                cureplan.Rate_level = 1;
            }

            if (LesscheckBox.Checked)
            {
                cureplan.Rate_level = -1;
            }

            cureplan.Recom_dose = Convert.ToDouble(RecomtextBox.Text.Trim());
            cureplan.Plan_dose = Convert.ToDouble(PlantextBox.Text.Trim());
            cureplan.Cal_dose = Convert.ToDouble(CaltextBox.Text.Trim());
            cureplan.Real_dose = Convert.ToDouble(RealtextBox.Text.Trim());
            cureplan.Else_things = elserichTextBox.Text.Trim();

            char[] ef = new char[10];

            if (AgecheckBox.Checked)
            {
                ef[1] = '1';
            }
            else
            {
                ef[0] = '0';
            }

            if (ZhengcheckBox.Checked)
            {
                ef[1] = '1';
            }
            else
            {
                ef[1] = '0';
            }

            if (HecheckBox.Checked)
            {
                ef[2] = '1';
            }
            else
            {
                ef[2] = '0';
            }

            if (BingcheckBox.Checked)
            {
                ef[3] = '1';
            }
            else
            {
                ef[3] = '0';
            }

            if (shoushucheckBox.Checked)
            {
                ef[4] = '1';
            }
            else
            {
                ef[4] = '0';
            }

            if (ATDcheckBox.Checked)
            {
                ef[5] = '1';
            }
            else
            {
                ef[5] = '0';
            }

            if (fufacheckBox.Checked)
            {
                ef[6] = '1';
            }
            else
            {
                ef[6] = '0';
            }


            if (JiacheckBox.Checked)
            {
                ef[7] = '1';
            }
            else
            {
                ef[7] = '0';
            }

            if (JiejiecheckBox.Checked)
            {
                ef[8] = '1';
            }
            else
            {
                ef[8] = '0';
            }


            if (qitacheckBox.Checked)
            {
                ef[9] = '1';
            }
            else
            {
                ef[9] = '0';
            }

            string effect = new string(ef);

            cureplan.Ef_factor = effect;
            cureplan.Ef_else = ElsethingtextBox.Text.Trim();




            presenthistory.updatePhysicalInspect(logId);
            labinspect.updateLabInspect(logId);
            cureplan.updateCurePlan(logId);
            physical.updatePhysicalInspect(logId);

        }

       

        
    }
}
