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
            SearchResultForm uf = new SearchResultForm(id, 0);
            uf.Show();
            //this.Hide();
        }

        

        

        

       
    }
}
