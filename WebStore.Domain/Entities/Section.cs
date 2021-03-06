﻿using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    public class Section:NamedEntity,IOrderedEntity
    {
        public int? ParentId { get; set; }
        public int Order { get; set; }
    }
}