using Examen.ApplicationCore.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configuration
{
    public class InvitationConfiguration : IEntityTypeConfiguration<Invitation>
    {
        public void Configure(EntityTypeBuilder<Invitation> builder)
        { //Configuration de la clé composée
            builder.HasKey(inv => new
            {
                inv.FeteFk,
                inv.InviteFk,
                inv.DateInvitation
            });

        }
    }
}
