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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CureFirstBtn_Click(object sender, EventArgs e)
        {
            CureFirst cf = new CureFirst();
            cf.Show();
        }

        private void RandomVisitBtn_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }

        private void CureSecondBtn_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.Show();
        }

        
    }
}
