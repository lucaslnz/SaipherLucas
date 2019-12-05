using SaipherLucas.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace SaipherLucas.Infra.Persistence.Map
{
    public class MapAeronave : EntityTypeConfiguration<Aeronave>
    {
        public MapAeronave()
        {
            ToTable("Aeronave");

            Property(p => p.Matricula).HasMaxLength(20).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_AERONAVE_MATRICULA") { IsUnique = true })).HasColumnName("Matricula");
            Property(p => p.Tipo).HasMaxLength(20).IsRequired().HasColumnName("Tipo");
        }
    }
}
