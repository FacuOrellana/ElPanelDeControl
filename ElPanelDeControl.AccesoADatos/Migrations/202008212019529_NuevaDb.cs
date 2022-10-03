namespace ElPanelDeControl.AccesoADatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevaDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lecturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CalderaId = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Temperatura = c.Double(nullable: false),
                        Nivel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lecturas");
        }
    }
}
