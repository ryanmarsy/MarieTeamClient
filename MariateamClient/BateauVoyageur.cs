using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariateamClient
{
    public class BateauVoyageur : Bateau
    {
        private int vitesseBatVoy;
        private List<Equipement> lesEquipements;

        public BateauVoyageur(int unId, string unNom, double uneLongueur, double uneLargeur,
                              int uneVitesse, List<Equipement> uneCollEquip)
                              : base(unId, unNom, uneLongueur, uneLargeur)
        {
            vitesseBatVoy = uneVitesse;
            lesEquipements = uneCollEquip;
        }

        public double getVitesseBatVoy()
        {
            return vitesseBatVoy;
        }

        public void setVitesseBatVoy(int uneVitesse)
        {
            vitesseBatVoy = uneVitesse;
        }

        public List<Equipement> getLesEquipements()
        {
            return lesEquipements;
        }

        public void setLesEquipements(List<Equipement> uneCollEquip)
        {
            lesEquipements = uneCollEquip;
        }

        public override string ToString()
        {
            string str = base.ToString() +
                         "Vitesse : " + vitesseBatVoy + " noeuds\n" +
                         "Liste des équipements du bateau :\n";
            foreach (Equipement e in lesEquipements)
            {
                str += "- " + e.ToString() + "\n";
            }
            return str;
        }
    }
}
