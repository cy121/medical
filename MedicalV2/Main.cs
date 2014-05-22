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

        private void button1_Click(object sender, EventArgs e)
        {
            CureFirst cf = new CureFirst();
            cf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CureSecond cs = new CureSecond();
            cs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandomVisit rv = new RandomVisit();
            rv.Show();
        }
    }
}
