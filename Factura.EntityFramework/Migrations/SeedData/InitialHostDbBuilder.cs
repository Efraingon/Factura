using FacturaApp.EntityFramework;
using EntityFramework.DynamicFilters;

namespace FacturaApp.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly FacturaAppDbContext _context;

        public InitialHostDbBuilder(FacturaAppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
