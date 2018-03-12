using Syntra.VDOAP.CProef.Models.Persistence.Data.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syntra.VDOAP.CProef.Models.Persistence.Data.Seeding
{
    public class SeedManager
    {
        public static void Initialize(IApplicationContext context)
        {
            SeedLanguages(context);
        }

        private static void SeedLanguages(IApplicationContext context)
        {
            if (context.Languages.Any())
                return;

            ///context.Languages.Add(new Language());
            /// context.Languages.Add(new Language());
            ///  context.Languages.Add(new Language());
            ///  context.Languages.Add(new Language());
            ///  

            context.Languages =new List<Language>()
                {
                new Language(),
                new Language(),
                new Language()
            };
        }
    }
}
