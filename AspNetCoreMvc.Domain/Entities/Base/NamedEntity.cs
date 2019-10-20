using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreMvc.Domain.Entities.Base.Interfaces;

namespace AspNetCoreMvc.Domain.Entities.Base
{
    public class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }
}
