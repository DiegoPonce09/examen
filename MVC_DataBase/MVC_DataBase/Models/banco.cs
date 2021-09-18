namespace MVC_DataBase.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class banco : DbContext
    {
        // Your context has been configured to use a 'banco' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVC_DataBase.Models.banco' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'banco' 
        // connection string in the application configuration file.
        public banco()
            : base("name=banco.html")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<cuentaBancaria> CuentaBancarias { get; set; }
        public virtual DbSet<tipocuentabancaria > Tipocuentabancarias { get; set; }
        public virtual DbSet<transacciones> Transacciones { get; set; }
        public virtual DbSet<tipoTransacciones> TipoTransacciones { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}