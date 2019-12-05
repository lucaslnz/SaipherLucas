using SaipherLucas.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SaipherLucas.Infra.Persistence.Map
{
    public class MapAeroporto : EntityTypeConfiguration<Aeroporto>
    {
        public MapAeroporto()
        {
            ToTable("Aeroporto");

            Property(p => p.Sigla).HasMaxLength(40).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_AEROPORTO_SIGLA") { IsUnique = true })).HasColumnName("Sigla");
            Property(p => p.Nome).HasMaxLength(70).IsRequired().HasColumnName("Nome");
        }
    }
}
