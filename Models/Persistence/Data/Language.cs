using System;
using System.Collections.Generic;
using System.Text;
using Syntra.VDOAP.CProef.Models.Abstraction;

namespace Syntra.VDOAP.CProef.Models
{
    public class Language : ILanguage
    {
        public Guid Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset ModifiedAt { get; set; }


        public Language()
        {
            this.Id = Guid.NewGuid();
            CreatedAt = ModifiedAt = DateTimeOffset.UtcNow;
        }
    }
}
