using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetCalculatrice
{
    public partial class FmScientifique : Form
    {
        Double resultat = 0;
        String operation = "";
        bool enter_value = false;
        String val1, val2;
        int val;
        bool Egale;

        public FmScientifique()
        {
            InitializeComponent();
        }

        private void FmScientifique_Load(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void operateurs(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (resultat != 0)
            {
                btnEgale.PerformClick();
                enter_value = true;
                operation = btn.Text;
                txtbAffichage2.Text = resultat + "  " + operation;

            }
            else
            {
                operation = btn.Text;
                resultat = Double.Parse(txtbAffiche.Text);
                txtbAffiche.Text = "";
                txtbAffichage2.Text = resultat + "  " + operation;
            }
            val1 = txtbAffichage2.Text;

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            if (txtbAffiche.Text.Length > 0)
            {
                txtbAffiche.Text = txtbAffiche.Text.Remove(txtbAffiche.Text.Length - 1, 1);
            }

            if (txtbAffiche.Text == "")
            {
                txtbAffiche.Text = "0";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtbAffiche.Text = "0";
            resultat = 0;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtbAffiche.Text = "0";
        }

        private void btnEgale_Click(object sender, EventArgs e)
        {
            val2 = txtbAffiche.Text;
            txtbAffichage2.Text = "";
            switch (operation)
            {
                case "+":
                    txtbAffiche.Text = (resultat + Double.Parse(txtbAffiche.Text)).ToString();
                    break;
                case "-":
                    txtbAffiche.Text = (resultat - Double.Parse(txtbAffiche.Text)).ToString();
                    break;
                case "x":
                    txtbAffiche.Text = (resultat * Double.Parse(txtbAffiche.Text)).ToString();
                    break;
                case "/":
                    txtbAffiche.Text = (resultat / Double.Parse(txtbAffiche.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultat = Double.Parse(txtbAffiche.Text);
            operation = "";
            Egale = true;

            btnSupprimer.Visible = true;
            txtbHistorique.AppendText(val1 + "  " + val2 + " = " + "\n");
            txtbHistorique.AppendText("\n\t" + txtbAffiche.Text + "\n\n");
            // lblHistorique.Text = "";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            txtbHistorique.Clear();
            //if(lblHistorique.Text == "")
            //{
            //    lblHistorique.Text = "";
            //}
            btnSupprimer.Visible = false;
            txtbHistorique.ScrollBars = 0;
        }

        private void btnXCarre_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffichage2.Text);
            val = Math.Pow(val, 2);
            txtbAffiche.Text = val.ToString();
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            val = Math.Pow(val, 3);
            txtbAffiche.Text = val.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            val = Math.Sqrt(val);
            txtbAffiche.Text = val.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            val = 1 / val;
            txtbAffiche.Text = val.ToString();
        }

        private void btnTangnt_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            val = Math.Tan(val);
            txtbAffiche.Text = val.ToString();
        }

        private void btnCosinus_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            val = Math.Cos(val);
            txtbAffiche.Text = val.ToString();
        }

        private void btnSinus_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            val = Math.Sin(val);
            txtbAffiche.Text = val.ToString();
        }

        private void btnLogarithme_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            val = Math.Log(val);
            txtbAffiche.Text = val.ToString();
        }

        private void btnExponentiel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDegre_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLognep_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            val = Math.Log(val);
            txtbAffiche.Text = val.ToString();
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            val = Math.PI;
            txtbAffiche.Text = val.ToString();
        }

        private void btnFactoriel_Click(object sender, EventArgs e)
        {
            double val = double.Parse(txtbAffiche.Text);
            double resultat = 1;
            for(double i = val; i > 1; i--) resultat *= i;

            txtbAffiche.Text = resultat.ToString();
        }

        private void btnUnsur_Click(object sender, EventArgs e)
        {

        }

        private void txtbAffiche_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_only(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if ((txtbAffiche.Text == "0") || (enter_value) || Egale)
            {
                txtbAffiche.Text = "";
                txtbAffiche.Clear();
                Egale = false;
                enter_value = false;
            }

            if (btn.Text == ",")
            {
                if (!txtbAffiche.Text.Contains(","))
                    txtbAffiche.Text = txtbAffiche.Text + btn.Text;
            }
            else
            {
                txtbAffiche.Text = txtbAffiche.Text + btn.Text;
            }
        }
    }
}
