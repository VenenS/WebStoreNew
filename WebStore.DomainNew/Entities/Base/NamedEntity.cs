using WebStore.DomainNew.Entities.Base.Interfaces;

namespace WebStore.DomainNew.Entities.Base
{
    public class NamedEntity : INamedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}