﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using DJGO.ABPGMEdu.Authorization.Roles;
using DJGO.ABPGMEdu.Authorization.Users;
using DJGO.ABPGMEdu.MultiTenancy;

namespace DJGO.ABPGMEdu.EntityFramework
{
    public class ABPGMEduDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABPGMEduDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPGMEduDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPGMEduDbContext since ABP automatically handles it.
         */
        public ABPGMEduDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABPGMEduDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABPGMEduDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
