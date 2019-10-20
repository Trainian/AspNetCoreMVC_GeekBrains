using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreMvc.Domain.Entities.Base.Interfaces
{
    public interface INamedEntity : IBaseEntity
    {
        /// <summary>
        /// Наименование
        /// </summary>
        string Name { get; set; }
    }
}
