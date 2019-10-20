using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreMvc.Domain.Entities.Base.Interfaces
{
    public interface IOrderedEntity : INamedEntity
    {
        /// <summary>
        /// Порядок
        /// </summary>
        int Order { get; set; }
    }
}
