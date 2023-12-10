using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domains
{ public enum TypeFete
    { Anniversaire,
        Mariage,
        Autre

    }
    public class Fete
    {
        public int idFete  { get; set; }
        [Required (ErrorMessage="Invalide")]
        public string Description { get; set; }
        public TypeFete type  { get; set; }
        [Range(1,250)]
        public int NbInvitesMax{ get; set; }
        public int Duree { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateFete  { get; set; }
        public Salle Salle { get; set; }
        public int SalleFk { get; set; }
        public IList<Invitation> Invitations { get; set; }
    }
}
