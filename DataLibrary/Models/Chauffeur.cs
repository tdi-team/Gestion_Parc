using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Chauffeur
    {
        public int idChauffeur { get; set; }
        public string nomChauffeurs { get; set; }
        public string prenomChauffeur { get; set; }
        public string telChauffeur { get; set; }
        public int StatusChauffeur { get; set; }
        public string numeroPermis { get; set; }
        public string typePermis { get; set; }
    }
}
