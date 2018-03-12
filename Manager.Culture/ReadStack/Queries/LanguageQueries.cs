using Syntra.VDOAP.CProef.Manager.Culture.ReadStack.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syntra.VDOAP.CProef.Manager.Culture.ReadStack.Queries.Abstraction;
using Syntra.VDOAP.CProef.Models.Persistence.Data.Abstraction;
using Syntra.VDOAP.CProef.Models.Persistence.Data;
using Syntra.VDOAP.CProef.Models;

namespace Syntra.VDOAP.CProef.Manager.Culture.ReadStack.Queries
{
    public class LanguageQueries
         : Abstraction.IGetLanguageOverview
    {

        private IApplicationContext _context;

        public LanguageQueries()
        {
            _context = new ApplicationContext();
        }

        private IQueryable<Language> Languages()
        {
            return _context.Languages.AsQueryable();
        }

        public IEnumerable<LanguageItem> GetLanguageOverview()
        {
            return Languages;
            
        }

        IEnumerable<object> IGetLanguageOverview.GetLanguageOverview()
        {
            throw new NotImplementedException();
        }
    }
}
