using System.Linq;
using FacturaApp.EntityFramework;
using FacturaApp.MultiTenancy;

namespace FacturaApp.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly FacturaAppDbContext _context;

        public DefaultTenantCreator(FacturaAppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
