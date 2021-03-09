using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Assurance
    {
        public int idAssurance { get; set; }
        public int Vehicule { get; set; }
        public DateTime DateDebutAssurance { get; set; }
        public DateTime DateFinAssurance { get; set; }
        public float CoutAssurance { get; set; }
    }
}
