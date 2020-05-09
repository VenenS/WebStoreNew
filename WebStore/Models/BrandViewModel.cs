﻿using WebStore.DomainNew.Entities.Base.Interfaces;

namespace WebStore.Models
{
    public class BrandViewModel:INamedEntity,IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductsCount { get; set; }
        public int Order { get; set; }

    }
}