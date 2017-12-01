using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP6_Programmation_III
{
    public partial class frmMain : Form
    {

        #region Variables
        private Boolean DessinEnCours;
        private frmNewDraw Nouveau = new frmNewDraw();
        private Dessin Dess;
        Random r = new Random();
        Graphics g;
        private Color Couleur;
        #endregion

        #region Methods
        public frmMain()
        {
            InitializeComponent();

            Nouveau.ShowDialog();
            this.Couleur = Color.Black;
            this.DessinEnCours = false;
            Dess = new Dessin(Nouveau.Nom, Nouveau.Date,
                Math.Round(r.NextDouble() * (56.78 - 12.34) + 12.34, 2));
            g = plDessin.CreateGraphics();
        }

        private void plDessin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.DessinEnCours = true;
                this.Dess.AjouterPoint(plDessin.PointToClient(Cursor.Position));
                this.Dess.Dessiner(g);
            }
        }

        private void plDessin_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.DessinEnCours)
            {
                this.Dess.Dessiner(g);
                this.Dess.AjouterPoint(plDessin.PointToClient(Cursor.Position));
            }
        }

        private void plDessin_MouseUp(object sender, MouseEventArgs e)
        {
            this.DessinEnCours = false;
        }

        private void plDessin_MouseLeave(object sender, EventArgs e)
        {
            this.DessinEnCours = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            Nouveau.ShowDialog();
            if (Nouveau.DialogResult == DialogResult.Cancel)
            {
                plDessin.Refresh();
                Dessin NewOne = new Dessin(Nouveau.Nom, Nouveau.Date, Math.Round(r.NextDouble() * (56.78 - 12.34) + 12.34, 2));
            }

            else
                return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dess.Serialize();
            MessageBox.Show("Votre dessin a été enregistré avec succès.", "Bravo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpfFichiers = new OpenFileDialog();
            OpfFichiers.Filter = "All Files (*.*)|*.*"; ;
            OpfFichiers.FilterIndex = 1;
            OpfFichiers.Multiselect = false;

            if (OpfFichiers.ShowDialog() == DialogResult.OK)
            {
                string Path = OpfFichiers.FileName;
                Dessin OpenDes = new Dessin(null, DateTime.Now, 0.0);
                OpenDes = OpenDes.Deserialize(Path);
                plDessin.Refresh();
                int indice = 0;
                foreach (Point p in OpenDes.Coords)
                {
                    OpenDes.Redessiner(g, indice);
                    indice++;
                }
                indice = 0;
            }
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            Dess.Save();
        }
    }
}
#endregion