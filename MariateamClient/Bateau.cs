using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariateamClient
{
    public class Bateau
    {
        private int idBat;
        private string nomBat;
        private double longueurBat;
        private double largeurBat;

        public Bateau(int unId, string unNom, double uneLongueur, double uneLargeur)
        {
            idBat = unId;
            nomBat = unNom;
            longueurBat = uneLongueur;
            largeurBat = uneLargeur;
        }

        public override string ToString()
        {
            string str = "Nom du bateau : " + nomBat + "\n" +
                         "Longueur : " + longueurBat + " mètres\n" +
                         "Largeur : " + largeurBat + " mètres\n";
            return str;
        }

        public int getIdBat()
        {
            return idBat;
        }

        public void setIdBat(int unId)
        {
            idBat = unId;
        }

        public string getNomBat()
        {
            return nomBat;
        }

        public void setNomBat(string unNom)
        {
            nomBat = unNom;
        }

        public double getLongueurBat()
        {
            return longueurBat;
        }

        public void setLongueurBat(double uneLongueur)
        {
            longueurBat = uneLongueur;
        }

        public double getLargeurBat()
        {
            return largeurBat;
        }

        public void setLargeurBat(double uneLargeur)
        {
            largeurBat = uneLargeur;
        }

    }
}
