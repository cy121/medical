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
    public partial class SearchFollowVisitForm : Form
    {
        public SearchFollowVisitForm()
        {
            InitializeComponent();
        }

        private void FVSearchBtn_Click(object sender, EventArgs e)
        {
            string id = this.LogIdTextBox.Text;
            new AddFollowVisitForm(id).Show();
            //this.Hide();
        }

        private void AddFVBtn_Click(object sender, EventArgs e)
        {
            new AddFollowVisitForm().Show();
        }

        

        

       
    }
}
