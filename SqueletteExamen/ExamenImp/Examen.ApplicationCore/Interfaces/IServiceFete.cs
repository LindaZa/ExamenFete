using AM.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
   public interface IServiceFete : IService<Fete>
    {
        public int nbfete(TypeFete,Salle);
       // public int duree;
    }
}
