using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using FacturaApp.Authorization.Roles;
using FacturaApp.Authorization.Users;
using FacturaApp.Models;
using FacturaApp.MultiTenancy;

namespace FacturaApp.EntityFramework
{
    public class FacturaAppDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DbSet<contactoClientes> ContactoCliente {get;set;}
        public DbSet<Status> StatusFactura { get; set; }
        public DbSet<Clientes> Cliente { get; set; }
        public DbSet<FacturaModel> Factura { get; set; }
        public DbSet<FacturaDocumentoModel> FacturaDocumento { get; set; }
        public DbSet<ProductoModel> ProductoModel { get; set; }


        public FacturaAppDbContext()
           : base("Default")
          // : base("FacturaApp")

        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in FacturaAppDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of FacturaAppDbContext since ABP automatically handles it.
         */
        public FacturaAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public FacturaAppDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public FacturaAppDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
