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
    public partial class RandomVisit : Form
    {
        public RandomVisit()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string id = LogIdTextBox.Text;
            FollowVisitForm fvf = new FollowVisitForm(id);
            fvf.Show();
            this.Hide();
        }
    }
}
