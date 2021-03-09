using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Vidange
    {
        public int idVidange { get; set; }
        public int Vehicule { get; set; }
        public DateTime DateVidange { get; set; }
        public int Kilometrage { get; set; }
    }
}
