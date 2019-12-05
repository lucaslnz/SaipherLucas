namespace SaipherLucas.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTabelaPlano : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PlanoVoo", name: "IdAeroportoOrigemome", newName: "IdAeroportoOrigem");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.PlanoVoo", name: "IdAeroportoOrigem", newName: "IdAeroportoOrigemome");
        }
    }
}
