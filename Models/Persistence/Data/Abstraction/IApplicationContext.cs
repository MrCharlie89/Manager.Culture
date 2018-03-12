using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Syntra.VDOAP.CProef.Models.Persistence.Data.Abstraction
{
    public interface IApplicationContext
    {



      IEnumerable<Language> Languages { get; set; }
    }
}
