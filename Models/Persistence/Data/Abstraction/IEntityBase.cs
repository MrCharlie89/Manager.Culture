using System;
using System.Collections.Generic;
using System.Text;

namespace Syntra.VDOAP.CProef.Models.Abstraction
{
    public interface IEntityBase
    {
        /// <summary>
        /// the Id for the entities
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// date time marker when the entity has been created
        /// </summary>
        DateTimeOffset CreatedAt { get; }  

        /// <summary>
        /// date time marker when the entity has been modified last time
        /// </summary>
        DateTimeOffset ModifiedAt { get; }
    }
}
