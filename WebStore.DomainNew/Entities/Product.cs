using System.ComponentModel.DataAnnotations.Schema;
using WebStore.DomainNew.Entities.Base;
using WebStore.DomainNew.Entities.Base.Interfaces;

namespace WebStore.DomainNew.Entities
{
    [Table("Products")]
    public class Product:NamedEntity,IOrderedEntity
    {
        public int Order { get; set; }
        public int SectionId { get; set; }
        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }
        public int? BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}