using RepositoryPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repositories
{
    public interface IPartRepository : IRepository<Part>
    {
        IEnumerable<Part> GetPartsByProductId(int productId);
    }
}
