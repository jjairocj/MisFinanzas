using MisFinanzas.EntityFramework;
using EntityFramework.DynamicFilters;

namespace MisFinanzas.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MisFinanzasDbContext _context;

        public InitialHostDbBuilder(MisFinanzasDbContext context)
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
