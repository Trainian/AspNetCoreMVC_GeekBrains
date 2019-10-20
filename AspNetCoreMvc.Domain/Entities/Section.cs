using System;
using System.Collections.Generic;
using System.Text;
using AspNetCoreMvc.Domain.Entities.Base;

namespace AspNetCoreMvc.Domain
{
    public class Section : OrderedEntity
    {
        /// <summary>
        /// Родительская секция (при наличии)
        /// </summary>
        public int? ParentId { get; set; }
    }
}
