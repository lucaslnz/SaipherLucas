using SaipherLucas.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SaipherLucas.Infra.Persistence.Map
{
    public class MapVoo : EntityTypeConfiguration<Voo>
    {
        public MapVoo()
        {
            ToTable("Voo");

            Property(p => p.Numero).HasMaxLength(15).IsRequired().HasColumnName("Numero");
            Property(p => p.Data).IsRequired().HasColumnName("Data");
            Property(p => p.Horario).IsRequired().HasColumnName("Horario");
        }
    }
}
