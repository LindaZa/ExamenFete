using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domains
{
   public class Salle
    {
        public int IdSalle{ get; set; }
        public string NomSalle { get; set;}
        public string AdresseSalle { get; set; }
        public int Capacite{ get; set; }
        public double PrixParHeure { get; set; }
        public  IList<Fete> Fetes { get; set; }



    }
}
