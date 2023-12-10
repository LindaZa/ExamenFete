using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domains
{
    public class Invitation
    {
        public DateTime DateInvitation { get; set; }
        public bool ConfirmeInvitation { get; set; }
        [ForeignKey("InviteFk")]
        public Invite Invite{ get; set; }
        [ForeignKey("FeteFk")]
        public Fete Fete { get; set; }
        public int InviteFk { get; set; }
        public int FeteFk { get; set; }

    }
}
