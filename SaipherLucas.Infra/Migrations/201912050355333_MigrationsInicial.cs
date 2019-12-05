namespace SaipherLucas.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationsInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aeronave",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Matricula = c.String(nullable: false, maxLength: 20, unicode: false),
                        Tipo = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Matricula, unique: true, name: "UK_AERONAVE_MATRICULA");
            
            CreateTable(
                "dbo.Aeroporto",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Sigla = c.String(nullable: false, maxLength: 40, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 70, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Sigla, unique: true, name: "UK_AEROPORTO_SIGLA");
            
            CreateTable(
                "dbo.PlanoVoo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IdAeroportoOrigemome = c.Guid(nullable: false),
                        IdAeroportoDestino = c.Guid(nullable: false),
                        IdAeronave = c.Guid(nullable: false),
                        IdVoo = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Voo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Numero = c.String(nullable: false, maxLength: 15, unicode: false),
                        Data = c.DateTime(nullable: false),
                        Horario = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Aeroporto", "UK_AEROPORTO_SIGLA");
            DropIndex("dbo.Aeronave", "UK_AERONAVE_MATRICULA");
            DropTable("dbo.Voo");
            DropTable("dbo.PlanoVoo");
            DropTable("dbo.Aeroporto");
            DropTable("dbo.Aeronave");
        }
    }
}
