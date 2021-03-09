using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Mission
    {
        public int idMission { get; set; }
        public DateTime DateDepart { get; set; }
        public DateTime DateRetour { get; set; }
        public string LieuDepart { get; set; }
        public string Destination { get; set; }
        public int NombrePersonnes { get; set; }
        public string _Object { get; set; }
        public int Distance { get; set; }
    }
}
