using RepositoryPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        void UpdateProductName(int productId, string productName);
        IEnumerable<Product> GetProductsByProjectId(int projectId);
    }
}
