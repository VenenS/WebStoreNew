using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebStore.DomainNew.Entities;
using WebStore.DAL.Context;
using WebStore.DomainNew.Filters;
using WebStore.Infrastructure.Interface;

namespace WebStore.Infrastructure.Implementation
{
    public class SqlProductData : InMemoryProductData
    {
        private readonly WebStoreContext _context;

        public SqlProductData(WebStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Section> GetCategories()
        {
            return _context.Sections.ToList();
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var query = _context.Products
                .Include(p => p.Section)
                .Include(p => p.Brand)
                .AsQueryable();
            if (filter.BrandId.HasValue)
                query = query.Where(c => c.BrandId.HasValue &&
                                         c.BrandId.Value.Equals(filter.BrandId.Value));
            if (filter.SectionId.HasValue)
                query = query.Where(c =>
                    c.SectionId.Equals(filter.SectionId.Value));
            return query.ToList();
        }
        public Product GetProductById(int id)
        {
            return _context.Products
                .Include(p => p.Section)
                .Include(p => p.Brand)
                .FirstOrDefault(p => p.Id == id);
        }
    }
}