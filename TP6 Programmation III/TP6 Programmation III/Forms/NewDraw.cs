using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6_Programmation_III
{
    public partial class frmNewDraw : Form
    {
        private string m_Nom;
        private DateTime m_Date;

        #region Properties
        public string Nom
        {
            get { return m_Nom; }
            set
            {
                m_Nom = value;
            }
        }

        public DateTime Date
        {
            get { return m_Date; }
            set
            {
                m_Date = value;
            }
        }
#endregion


        public frmNewDraw()
        {
            InitializeComponent();
            lblDate.Text += DateTime.Now.ToShortDateString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                bool End = MessageBox.Show("Vous devez entrer un nom de dessin valide pour commencer.", "Avertissement",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Hand)== DialogResult.OK;
                if (End)
                {
                    return;
                }
                else
                {
                    Application.Exit();
                }
            }
            Nom = txtName.Text;
            Date = DateTime.Now;
            this.Close();

        }
        //Si on essaye de sortir sans avoir choisi un nom 
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (txtName.Text == "")
            {
                MessageBox.Show("Vous devez entrer un nom de dessin valide pour commencer.", "Avertissement",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                e.Cancel = true;
            }
        }
    }
}
