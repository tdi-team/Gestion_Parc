using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Fonctionnaire
    {
        public int idFonctionnaire { get; set; }
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public string SituationFamiliale { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public DateTime DateRecrutement { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Adresse { get; set; }
        public int Grade { get; set; }
        public int _Service { get; set; }
        public string FullName { get { return this.Nom + " " + this.Prenom; } }
    }
}
