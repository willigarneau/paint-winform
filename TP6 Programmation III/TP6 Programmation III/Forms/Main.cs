using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TP6_Programmation_III
{
    public partial class frmMain : Form
    {

        #region Variables
        private Boolean DessinEnCours;
        private bool ToErase;
        private frmNewDraw Nouveau = new frmNewDraw();
        private Dessin Dess;
        int m_nbClic = 0;
        int m_X1 = 0;
        int m_Y1 = 0;
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
                if (Path[Path.Length -1]== 't')
                {
                    //OpenDes.DrawFromTextFile(Path);
                }
                else
                {
                    OpenDes = OpenDes.Deserialize(Path);
                }
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

        private void btnProperties_Click(object sender, EventArgs e)
        {
            Forms.Properties frmProperties = new Forms.Properties(Dess);
            frmProperties.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(brush);
            int i = 0;
            plDessin.Refresh();
            foreach (Point p in Dess.Coords)
            {
                g.DrawEllipse(pen, Dess.Coords[i].X, Dess.Coords[i].Y, 6, 6);
                i++;
            }
        }

        private void btnNormalise_Click(object sender, EventArgs e)
        {
            int Indice = 0, X = Dess.Coords[0].X, Y = Dess.Coords[0].Y, Hauteur;
            Point NouvPoint;
            List<Point> CpyCoords = new List<Point>();

            //Traitement
            while (Indice < Dess.Coords.Count)
            {
                if (X > Dess.Coords[Indice].X)
                {
                    X = Dess.Coords[Indice].X;
                }
                if (Y > Dess.Coords[Indice].Y)
                {
                    Y = Dess.Coords[Indice].Y;
                }
                Indice++;
            }

            Indice = 0;
            Hauteur = plDessin.Height + Y;

            while (Indice < Dess.Coords.Count)
            {
                NouvPoint = Dess.Coords[Indice];
                NouvPoint.X = NouvPoint.X - X;
                NouvPoint.Y = NouvPoint.Y - Y;
                Dess.Coords[Indice] = NouvPoint;
                Indice++;
            }
            plDessin.Refresh();
            CpyCoords = Dess.Coords;
            Remake(g, CpyCoords);
        }

        private void btnSurface_Click(object sender, EventArgs e)
        {
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;
            int surf = 0;
            int i = 0;

            while (i < Dess.Coords.Count)
            {
                if (x1<Dess.Coords[i].X)
                {
                    x1 = Dess.Coords[i].X;
                }
                if (x2 > Dess.Coords[i].X)
                {
                    x2 = Dess.Coords[i].X;
                }
                if (y1 < Dess.Coords[i].Y)
                {
                    y1 = Dess.Coords[i].Y;
                }
                if (y2 > Dess.Coords[i].Y)
                {
                    y2 = Dess.Coords[i].Y;
                }
                i++;
            }
            surf = (x2 - x1) * (y2 - y1);

            MessageBox.Show("Le nombre total de pixels utilisés : " + surf.ToString(), "Information sur les pixels", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEncadrer_Click(object sender, EventArgs e)
        {
            int Indice = 0;
            Pen Crayon = new Pen(Color.Black, 5);
            Point P1 = new Point();
            Point P2 = new Point();
            Point P3 = new Point();
            Point P4 = new Point();
            List<Point> Liste = new List<Point>();

            P3.X = plDessin.Width;
            P2.Y = plDessin.Height;

            //Traitement
            while (Indice < Dess.Coords.Count)
            {
                if (P2.X < Dess.Coords[Indice].X)
                {
                    P2.X = Dess.Coords[Indice].X;
                    P4.X = Dess.Coords[Indice].X;
                }
                if (P3.X > Dess.Coords[Indice].X)
                {
                    P3.X = Dess.Coords[Indice].X;
                    P1.X = Dess.Coords[Indice].X;
                }
                if (P3.Y < Dess.Coords[Indice].Y)
                {
                    P3.Y = Dess.Coords[Indice].Y;
                    P4.Y = Dess.Coords[Indice].Y;
                }
                if (P2.Y > Dess.Coords[Indice].Y)
                {
                    P2.Y = Dess.Coords[Indice].Y;
                    P1.Y = Dess.Coords[Indice].Y;
                }
                Indice++;
            }

            plDessin.Refresh();
            Liste = Dess.Coords;
            Remake(g, Liste);
            //Dessiner le carré
            g.DrawLine(Crayon, P1, P2);
            g.DrawLine(Crayon, P1, P3);
            g.DrawLine(Crayon, P3, P4);
            g.DrawLine(Crayon, P2, P4);
        }

        private void btnAgrandirX_Click(object sender, EventArgs e)
        {
            int Indice = 0;
            SolidBrush Brosse = new SolidBrush(Color.Black);

            while (Indice < Dess.Coords.Count)
            {
                g.FillRectangle(Brosse, Dess.Coords[Indice].X, Dess.Coords[Indice].Y, 10, 5);
                Indice++;
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            //Traitement
            MessageBox.Show("Vos deux prochains clics vont effacer une partie de votre dessin", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ToErase = true;
        }

        private void btnAgrandirY_Click(object sender, EventArgs e)
        {
            int Indice = 0;
            SolidBrush Brosse = new SolidBrush(Color.Black);

            //Traitement
            while (Indice < Dess.Coords.Count)
            {
                g.FillRectangle(Brosse, Dess.Coords[Indice].X, Dess.Coords[Indice].Y, 5, 10);
                Indice++;
            }
        }

        private void plDessin_MouseClick(object sender, MouseEventArgs e)
        {
            if (ToErase)
            {

                int X2 = 0, Y2 = 0, X3, Y3;
                SolidBrush Efface = new SolidBrush(plDessin.BackColor);
                Rectangle SectionAEffacer = new Rectangle();
                List<Point> CopyCoords = new List<Point>();

                //Compter les clics pour faire le rectangle
                if (e.Button == MouseButtons.Left)
                {
                    if (m_nbClic == 0)
                    {
                        m_X1 = e.X;
                        m_Y1 = e.Y;
                        m_nbClic++;
                    }
                    else
                    {
                        X2 = e.X;
                        Y2 = e.Y;
                        m_nbClic++;
                    }
                }

                if (m_nbClic == 2)
                {
                    if (m_X1 > X2)
                    {
                        X3 = m_X1;
                        m_X1 = X2;
                        X2 = X3;
                    }
                    if (m_Y1 < Y2)
                    {
                        Y3 = m_Y1;
                        m_Y1 = Y2;
                        Y2 = Y3;
                    }

                    //Dimensions du rectangle
                    SectionAEffacer.Height = m_Y1 - Y2;
                    SectionAEffacer.Width = X2 - m_X1;
                    SectionAEffacer.X = m_X1;
                    SectionAEffacer.Y = m_Y1;

                    //Erase
                    CopyCoords = Dess.Coords;
                    Remake(g, Dess.Coords);
                    Dess.Supprimer(SectionAEffacer, CopyCoords);

                    ToErase = false;
                    m_nbClic = 0;
                }
            }
        }
        

        public void Remake(Graphics Graph, List<Point> LCoord)
        {
            g = Graph;
            int Indice = 0;
            SolidBrush Brosse = new SolidBrush(Color.Black);
            Pen p = new Pen(Brosse);
            //Traitement
            while (Indice < LCoord.Count)
            {
                Graph.DrawEllipse(p, LCoord[Indice].X, LCoord[Indice].Y, 6, 6);
                Indice++;
            }
        }
    }
}
#endregion