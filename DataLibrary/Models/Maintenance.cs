using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Maintenance
    {
        public int idMaintenance { get; set; }
        public DateTime DateMaintenance { get; set; }
        public string _Description { get; set; }
        public float Prix { get; set; }
        public int Vehicule { get; set; }
    }
}
