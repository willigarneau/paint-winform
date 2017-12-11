using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace TP6_Programmation_III
{
    [Serializable]
    public class Dessin
    {

        #region Variables
        private string m_NomDessin;
        private DateTime m_MomentCreation;
        private double m_Cost;
        public List<Point> m_Coords;
        public Color m_Couleur;
        private float m_Largeur;
        Graphics graph;
#endregion

        #region Properties
        public string Nom
        {
            get
            {
                return m_NomDessin;
            }
            set
            {
                m_NomDessin = value;
            }
        }

        public DateTime DateCreation
        {
            get
            {
                return m_MomentCreation;
            }
            set
            {
                m_MomentCreation = value;
            }
        }

        public double Cost
        {
            get
            {
                return m_Cost;
            }
            set
            {
                m_Cost = value;
            }
        }

        public List<Point> Coords
        {
            get
            {
                return m_Coords;
            }
            set
            {
                m_Coords = value;
            }
        }


        public Color Couleurs
        {
            get { return m_Couleur; }
            set
            {
                m_Couleur = value;
            }
        }

        public float Largeur
        {
            get { return m_Largeur; }
            set
            {
                m_Largeur = value;
            }
        }
#endregion

        public Dessin(string name, DateTime dateCreation, double cout)
        {
            Nom = name;
            DateCreation = dateCreation;
            Cost = cout;
            Coords = new List<Point>();
            Couleurs = Color.Black;
        }

        public bool AjouterPoint(Point pt)
        {
            this.Coords.Add(pt);
            return true;
        }

        public void Dessiner(Graphics g)
        {
            Brush b = new SolidBrush(this.m_Couleur);
            Pen p = new Pen(b);
            graph = g;
            if (this.Coords.Count > 0)
            {
                g.DrawEllipse(p, this.Coords.Last().X, this.Coords.Last().Y, 6, 6);
            }
        }

        Point TrouverCoinGH(List<Point> Coords)
        {
            Point Coin = Coords[0];
            int i = 0;
            while (i < Coords.Count)
            {
                if (Coin.X >= Coords[i].X)
                {
                    if (Coin.Y <Coords[i].Y)
                    {
                        Coin = Coords[i];
                    }
                }
                i++;
            }
            return Coin;
        }

        public int Supprimer(Rectangle Tosuppress, List<Point> Coords)
        {
            int i = 0, NbrSupp = 0, Supp = 0;
            SolidBrush Efface = new SolidBrush(Color.White);
            List<int> AEffacer = new List<int>();
            
            //Traitement
            while (i < Coords.Count)
            {
                if (Coords[i].X > Tosuppress.X && Coords[i].X < Tosuppress.Width + Tosuppress.X && Coords[i].Y > Tosuppress.Y - Tosuppress.Height
                    && Coords[i].Y < Tosuppress.Y)
                {
                    graph.FillRectangle(Efface, Coords[i].X, Coords[i].Y, 7, 7);
                    AEffacer.Add(i);
                    NbrSupp++;
                }
                i++;
            }
            i = 0;

            while (i < AEffacer.Count)
            {
                Coords.RemoveAt(AEffacer[i] - Supp);
                Supp++;
                i++;
            }

            i = Coords.Count;

            return NbrSupp;
        }

        public void Serialize()
        {
            Dessin ToSer = new Dessin(Nom, DateCreation, Cost);
            ToSer.Coords = Coords;
            IFormatter formatter = new BinaryFormatter();
            string Path = string.Format("{0}.don", ToSer.Nom);
            Stream stream = new FileStream(Path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, ToSer);
            stream.Close();
        }

        public Dessin Deserialize(string Path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream filestream = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read);
            Dessin ToDes = new Dessin(null, DateTime.Now, 0.0);
            ToDes = (Dessin)formatter.Deserialize(filestream);
            filestream.Close();
            return ToDes;
        }

        public void Save()
        {
            Dessin ToSave = new Dessin(Nom, DateCreation, Cost);
            ToSave.Coords = Coords;
            string ToFile = string.Format("{0} \r\n {1} \r\n {2} \r\n", ToSave.Nom, ToSave.DateCreation, ToSave.Cost);
            int i = 0;
            foreach (Point p in ToSave.Coords)
            {
                ToFile += string.Format("({0}, {1}) \r\n", ToSave.Coords[i].X, ToSave.Coords[i].Y);
                i++;
            }
            string Path = string.Format("{0}.txt", ToSave.Nom);
            FileStream TextFile = new FileStream(Path, FileMode.CreateNew, FileAccess.Write, FileShare.None);
            StreamWriter s = new StreamWriter(TextFile);
            s.Write(ToFile);
            TextFile.Close();
        }

        public void Redessiner(Graphics g, int i)
        {
            Brush b = new SolidBrush(this.m_Couleur);
            Pen p = new Pen(b);
            if (this.Coords.Count > 0)
            {
                g.DrawEllipse(p, this.Coords[i].X, this.Coords[i].Y, 6, 6);
            }
        }

        //public Dessin DrawFromTextFile(string Path)
        //{
        //    Dessin ToRead = new Dessin("", DateTime.Now, 0.0);
        //    string Text=File.ReadAllText(Path);
        //    string[] Decompile = Text.Split('\r');
        //    ToRead.Nom = Decompile[0];
        //    ToRead.DateCreation = DateTime.Parse(Decompile[1]);
        //    ToRead.Cost = Double.Parse(Decompile[2]);

        //    List<Point> Coords = new List<Point>();
        //    PointConverter p = new PointConverter();
        //    string[] SCoords = Decompile[3].Split('\n');
        //    int i = 0;
        //    foreach (string s in SCoords)
        //    {
        //        Coords.Add((Point)p.ConvertFromString(SCoords[i]));
        //        i++;
        //    }
        //    ToRead.Coords = Coords;
        //    return ToRead;
        //}
    }
}
