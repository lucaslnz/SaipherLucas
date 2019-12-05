using SaipherLucas.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SaipherLucas.Infra.Persistence.Map
{
    public class MapPlanoVoo : EntityTypeConfiguration<PlanoVoo>
    {
        public MapPlanoVoo()
        {
            ToTable("PlanoVoo");

            Property(p => p.IdAeroportoOrigem).IsRequired().HasColumnName("IdAeroportoOrigem");
            Property(p => p.IdAeroportoDestino).IsRequired().HasColumnName("IdAeroportoDestino");
            Property(p => p.IdAeronave).IsRequired().HasColumnName("IdAeronave");
            Property(p => p.IdVoo).IsRequired().HasColumnName("IdVoo");
        }
    }
}
