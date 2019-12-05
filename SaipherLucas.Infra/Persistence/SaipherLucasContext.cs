using SaipherLucas.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SaipherLucas.Infra.Persistence
{
    public class SaipherLucasContext : DbContext
    {
        public SaipherLucasContext() : base("SaipherLucasConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public IDbSet<Aeronave> Aeronaves { get; set; }
        public IDbSet<Aeroporto> Aeroportos { get; set; }
        public IDbSet<PlanoVoo> PlanosVoo { get; set; }
        public IDbSet<Voo> Voos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            #region Adiciona entidades mapeadas - Automaticamente via Assembly
            modelBuilder.Configurations.AddFromAssembly(typeof(SaipherLucasContext).Assembly);
            #endregion

            #region Adiciona entidades mapeadas - Automaticamente via NameSpace
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
