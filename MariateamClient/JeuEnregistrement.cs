using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariateamClient
{
    public class JeuEnregistrement
    {
        private MySqlDataReader reader;

        public JeuEnregistrement(string chaîneSQL)
        {
            MySqlCommand command = new MySqlCommand(chaîneSQL, new MySqlConnection("Server=217.160.103.88;Port=3306;Database=marieteam;Uid=marieteam;Pwd=marieteam123;"));
            try
            {
                command.Connection.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            this.reader = command.ExecuteReader();
        }

        public bool Lire()
        {
            return this.reader.Read();
        }

        public object getValeur(string nomChamp)
        {
            return this.reader[nomChamp];
        }

        public void fermer()
        {
            this.reader.Close();
        }
    }
}
