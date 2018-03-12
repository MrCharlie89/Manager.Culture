using Microsoft.EntityFrameworkCore;
using Syntra.VDOAP.CProef.Models.Persistence.Data.Seeding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Syntra.VDOAP.CProef.Models.Persistence.Data
{
    public class ApplicationContext : Abstraction.IApplicationContext
    {
        public static ApplicationContext Create(bool performSeed = true)
        {
            var context = new ApplicationContext();
            SeedManager.Initialize(context);
            return context;

        }

        public DbSet<Language> Languages { get; set; }
    }
}
