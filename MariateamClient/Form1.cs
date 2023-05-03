using System.Windows.Forms;

namespace MariateamClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void BrochurePDF()
        {
            // Créer un nouveau document PDF
            PDF document = new PDF("BateauVoyageur");

            // Charger tous les bateaux voyageurs à partir de la base de données
            List<BateauVoyageur> bateauxVoyageurs = Passerelle.ChargerLesBateauxVoyageurs();

            // Ajouter une page pour chaque bateau voyageur
            foreach (BateauVoyageur bateau in bateauxVoyageurs)
            {
                // Ajouter une image du bateau
                document.chargerImage("C:\\Users\\Ryan\\Pictures\\876868.jpg");

                // Ajouter le nom et les dimensions du bateau
                document.ecrireTexte(bateau.getNomBat());
                document.ecrireTexte("Longueur : " + bateau.getLongueurBat().ToString());
                document.ecrireTexte("Largeur : " + bateau.getLargeurBat().ToString());

                // Ajouter la liste des équipements du bateau
                document.ecrireTexte("Équipements :");
                foreach (Equipement equipement in bateau.getLesEquipements())
                {
                    document.ecrireTexte("- " + equipement.getlibEquip());
                }
            }

            // Fermer le document PDF
            document.fermer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Définir les propriétés de chaque colonne
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "unId";
            idColumn.HeaderText = "ID";
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nomColumn = new DataGridViewTextBoxColumn();
            nomColumn.DataPropertyName = "unNom";
            nomColumn.HeaderText = "Nom";
            dataGridView1.Columns.Add(nomColumn);

            DataGridViewTextBoxColumn longueurColumn = new DataGridViewTextBoxColumn();
            longueurColumn.DataPropertyName = "uneLongueur";
            longueurColumn.HeaderText = "Longueur";
            dataGridView1.Columns.Add(longueurColumn);

            DataGridViewTextBoxColumn largeurColumn = new DataGridViewTextBoxColumn();
            largeurColumn.DataPropertyName = "uneLargeur";
            largeurColumn.HeaderText = "Largeur";
            dataGridView1.Columns.Add(largeurColumn);

            // Charger les bateaux voyageurs à partir de la base de données
            List<BateauVoyageur> bateauxVoyageurs = Passerelle.ChargerLesBateauxVoyageurs();

            // Lier les données de la liste de bateaux au DataGridView
            dataGridView1.DataSource = bateauxVoyageurs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrochurePDF();
        }
    }
}