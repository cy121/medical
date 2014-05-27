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
    public partial class SearchUpdateForm : Form
    {
        public SearchUpdateForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string id = LogIdTextBox.Text;
            SearchResultForm fvf = new SearchResultForm(id, 1);
            fvf.Show();
            this.Hide();
        }
    }
}
