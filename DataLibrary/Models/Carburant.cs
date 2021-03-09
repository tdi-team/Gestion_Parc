using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Carburant
    {
        public int idCarburant { get; set; }
        public int typeCarburant { get; set; }
        public float prixCarburant { get; set; }
        public int Vehicule { get; set; }
        public DateTime dateAchat { get; set; }
        public float quantite { get; set; }
    }
}
