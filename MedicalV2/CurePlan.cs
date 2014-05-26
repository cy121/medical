﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace MedicalV2
{
    class CurePlan
    {
        private double twoh_rate;

        public double Twoh_rate
        {
            get { return twoh_rate; }
            set { twoh_rate = value; }
        }
        private double twentyfourh_rate;

        public double Twentyfourh_rate
        {
            get { return twentyfourh_rate; }
            set { twentyfourh_rate = value; }
        }
        private int rate_level;

        public int Rate_level
        {
            get { return rate_level; }
            set { rate_level = value; }
        }
        private double recom_dose;

        public double Recom_dose
        {
            get { return recom_dose; }
            set { recom_dose = value; }
        }
        private double cal_dose;

        public double Cal_dose
        {
            get { return cal_dose; }
            set { cal_dose = value; }
        }

        private double plan_dose;
        public double Plan_dose
        {
            get { return plan_dose; }
            set { plan_dose = value; }
        }
        private double real_dose;

        public double Real_dose
        {
            get { return real_dose; }
            set { real_dose = value; }
        }
        private string ef_factor;

        public string Ef_factor
        {
            get { return ef_factor; }
            set { ef_factor = value; }
        }
        private string ef_else;

        public string Ef_else
        {
            get { return ef_else; }
            set { ef_else = value; }
        }
        private string else_things;

        public string Else_things
        {
            get { return else_things; }
            set { else_things = value; }
        }

        public bool readCurePlan(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                con.Open();
                MySqlCommand command = new MySqlCommand("select * from cure_plan where log_id='" + lid + "'", con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    twoh_rate = reader.GetDouble(1);
                    twentyfourh_rate = reader.GetDouble(2);
                    rate_level = reader.GetInt32(3);
                    recom_dose = reader.GetDouble(4);
                    cal_dose = reader.GetDouble(5);
                    real_dose = reader.GetDouble(6);
                    ef_factor = reader.GetString(7);
                    ef_else = reader.GetString(8);
                    else_things = reader.GetString(9);
                    reader.Close();
                    con.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    con.Close();
                    return false;
                }
            }
        }

        public bool insertCurePlan(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string insert_sql = "insert into cure_plan(log_id,twoh_rate,twentyfourh_rate,rate_level,recom_dose," +
                "cal_dose,real_dose,ef_factor,ef_else,else_things) value('" + lid + "'," + twoh_rate + "," + twentyfourh_rate +
                "," + rate_level + "," + recom_dose + "," + cal_dose + "," + real_dose + ",'" + ef_factor + "','" + ef_else + "','" + else_things + "')";
                MySqlCommand command = new MySqlCommand(insert_sql, con);
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("保存成功！");
                }
                catch (MySqlException e)
                {
                    e.Message.ToString();
                    MessageBox.Show("无法保存！");
                }
                con.Close();
                return true;
            }
        }

        public bool updateCurePlan(string lid)
        {
            MySqlConnection con = CommonFunc.getConnection();
            if (con == null)
            {
                return false;
            }
            else
            {
                string update_sql = "update cure_plan set twoh_rate=" + twoh_rate + ", twentyfourh_rate=" + twentyfourh_rate + ",rate_level=" + rate_level +
                    ",recom_dose=" + recom_dose + ",cal_dose=" + cal_dose + ",real_dose=" + real_dose + ",ef_factor='" + ef_factor + "',ef_else='" + ef_else + "',else_things='" +
                    else_things + "' where log_id='" + lid + "'";
                
                MySqlCommand command = new MySqlCommand(update_sql, con);
                try
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("更新成功！");
                }
                catch (MySqlException e)
                {
                    e.Message.ToString();
                    MessageBox.Show("更新失败！");
                }
                con.Close();
                return true;
            }
            
        }
    }
}
