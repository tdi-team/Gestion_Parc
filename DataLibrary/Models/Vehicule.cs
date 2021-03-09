using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Vehicule
    {
        public int idVehicule { get; set; }
        public string matricule { get; set; }
        public int typeVehicule { get; set; }
        public DateTime DateAquisition { get; set; }
        public int Marque { get; set; }
        public string Modele { get; set; }
        public int statusVehicule { get; set; }
        public int niveauCarburant { get; set; }
        public int Kilometrage { get; set; }
        public float Consomage { get; set; }
        public int HorsePower { get; set; }
        public int CapaciteReservoir { get; set; }
        public string carName { get { return this.Modele; } }
    }
}
