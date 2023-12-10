using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Examen.ApplicationCore.Domains;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceFete : Service<Fete>, IServiceFete
    {
        public ServiceFete(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int nbfete(TypeFete 1, Salle 2)
        {
            throw new NotImplementedException();
        }
    }
}
