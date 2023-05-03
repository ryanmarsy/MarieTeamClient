using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariateamClient
{
    public class Equipement
    {
        private int idEquip;
        private string libEquip;

        public Equipement(int unId, string unLib)
        {
            idEquip = unId;
            libEquip = unLib;
        }

        public override string ToString()
        {
            return libEquip;
        }

        public int getIdEquip()
        {
            return idEquip;
        }

        public void setIdEquip(int unId)
        { 
            this.idEquip = unId;
        }

        public string getlibEquip()
        {
            return libEquip;
        }

        public void setLibEquip(string libelle)
        {
            this.libEquip = libelle;
        }
    }
}
