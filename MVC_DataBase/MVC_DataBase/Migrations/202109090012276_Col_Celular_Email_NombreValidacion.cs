namespace MVC_DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Col_Celular_Email_NombreValidacion : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.contactoes", newName: "contacto");
            AddColumn("dbo.contacto", "numerocelular", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.contacto", "email", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.contacto", "nombres", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.contacto", "numeroTelefono", c => c.String(nullable: false, maxLength: 100));
        }

        public override void Down()
        {
            AlterColumn("dbo.contacto", "nombres", c => c.String(maxLength: 200));
            DropColumn("dbo.contacto", "email");
            DropColumn("dbo.contactoes", "numerocelular");
            RenameTable(name: "dbo.contacto", newName: "contactoes");
        }
    }
}
