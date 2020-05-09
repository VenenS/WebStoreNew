using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Entities.Base;
using WebStore.DomainNew.Entities.Base.Interfaces;

namespace WebStore.DomainNew.Entities
{
    [Table("Sections")]
    public class Section:NamedEntity,IOrderedEntity
    {
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual Section ParentSection { get; set; }
        public int Order { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}