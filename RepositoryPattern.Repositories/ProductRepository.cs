using RepositoryPattern.Data;
using RepositoryPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryPattern.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(RepositoryPatternContext context) : base(context) { }

        public RepositoryPatternContext RepositoryPatternContext
        {
            get { return Context as RepositoryPatternContext; }
        }

        public IEnumerable<Product> GetProductsByProjectId(int projectId)
        {
            return RepositoryPatternContext.Products.Where(n => n.ProjectId == projectId).ToList();
        }

        public void UpdateProductName(int productId, string productName)
        {
            var product = Get(productId);
            product.ProductName = productName;
        }
    }
}
