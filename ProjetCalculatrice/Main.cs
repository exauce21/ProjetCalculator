using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace ProjetCalculatrice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEnergie_Click(object sender, EventArgs e)
        {

        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            //FmStandard f = new FmStandard();
            //f.MdiParent = this;
            //f.WindowState = FormWindowState.Maximized;
            //f.Show();
            this.Hide();
            using (FmStandard fs = new FmStandard())
            {
                fs.ShowDialog();
            }
        }

        private void btnScientifique_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FmScientifique fs = new FmScientifique())
            {
                fs.ShowDialog();
            }
        }
    }
}
