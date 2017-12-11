using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6_Programmation_III.Forms
{
    public partial class Properties : Form
    {
        Dessin NewDessin;
        public Properties(Dessin Des)
        {
            InitializeComponent();
            NewDessin = Des;
            txtName.Text = NewDessin.Nom;
            txtPrice.Text = NewDessin.Cost.ToString();
            txtDate.Text = NewDessin.DateCreation.ToShortDateString();
            txtNbrePoints.Text = NewDessin.Coords.Count.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            double PriceChange = 0;
            bool flag;
            string ConvertPrice;

            if (txtName.Text == "")
            {
                MessageBox.Show("Vous devez entrer un nom", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ConvertPrice = txtPrice.Text;

            flag = Double.TryParse(ConvertPrice, out PriceChange);
            if (!flag && PriceChange < 12.34 || PriceChange > 56.78)
            {
                MessageBox.Show("Votre nouveau montant doit se situer entre 12.34 et 56.78$", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            NewDessin.Nom = txtName.Text;
            NewDessin.Cost = PriceChange;

            MessageBox.Show("Vos modifications ont été effectuées !", "Félicitations :)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
