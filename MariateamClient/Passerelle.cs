using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariateamClient
{
    public static class Passerelle
    {
        public static List<Equipement> ChargerLesEquipements(int unIdBateau)
        {
            List<Equipement> collEquip = new List<Equipement>();
            string requete = "SELECT id, libelle_equipement FROM marieteam.equipement WHERE id = " + unIdBateau;
            JeuEnregistrement jeuEquipements = new JeuEnregistrement(requete);

            while (jeuEquipements.Lire())
            {
                Equipement equipement = new Equipement((int)jeuEquipements.getValeur("id"), (string)jeuEquipements.getValeur("libelle_equipement"));
                collEquip.Add(equipement);
            }

            jeuEquipements.fermer();
            return collEquip;
        }

        public static List<BateauVoyageur> ChargerLesBateauxVoyageurs()
        {
            List<BateauVoyageur> collBatVoy = new List<BateauVoyageur>();
            string requete = "SELECT id, libelle_bateau, longueur, largeur, vitesse FROM marieteam.bateau";
            JeuEnregistrement jeuBateauxVoyageurs = new JeuEnregistrement(requete);

            while (jeuBateauxVoyageurs.Lire())
            {
                int idBat = (int)jeuBateauxVoyageurs.getValeur("id");
                string nomBat = (string)jeuBateauxVoyageurs.getValeur("libelle_bateau");
                double longueurBat = (double)jeuBateauxVoyageurs.getValeur("longueur");
                double largeurBat = (double)jeuBateauxVoyageurs.getValeur("largeur");
                int vitesseBatVoy = (int)jeuBateauxVoyageurs.getValeur("vitesse");

                List<Equipement> lesEquipements = new List<Equipement>();
                lesEquipements = ChargerLesEquipements(Convert.ToInt32(idBat));

                BateauVoyageur batVoy = new BateauVoyageur(idBat, nomBat, longueurBat, largeurBat, vitesseBatVoy, lesEquipements);
                collBatVoy.Add(batVoy);
            }

            jeuBateauxVoyageurs.fermer();
            return collBatVoy;
        }
    }
}
