using System.Linq;
using MisFinanzas.EntityFramework;
using MisFinanzas.MultiTenancy;

namespace MisFinanzas.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MisFinanzasDbContext _context;

        public DefaultTenantCreator(MisFinanzasDbContext context)
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
