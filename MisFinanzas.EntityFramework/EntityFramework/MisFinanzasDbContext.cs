using System.Data.Common;
using Abp.Zero.EntityFramework;
using MisFinanzas.Authorization.Roles;
using MisFinanzas.MultiTenancy;
using MisFinanzas.Users;

namespace MisFinanzas.EntityFramework
{
    public class MisFinanzasDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MisFinanzasDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MisFinanzasDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MisFinanzasDbContext since ABP automatically handles it.
         */
        public MisFinanzasDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MisFinanzasDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MisFinanzasDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
