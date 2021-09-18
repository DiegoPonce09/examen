namespace MVC_DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablaEventos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.evento",
                c => new
                    {

                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 250),
                        fecha = c.DateTime(nullable: false),
                        contactos_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.contacto", t => t.contactos_id)
                .Index(t => t.contactos_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.evento", "contactos_id", "dbo.contacto");
            DropIndex("dbo.evento", new[] { "contactos_id" });
            DropTable("dbo.evento");
        }
    }
}
