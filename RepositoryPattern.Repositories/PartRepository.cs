using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data;
using RepositoryPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryPattern.Repositories
{
    public class PartRepository : Repository<Part>, IPartRepository
    {
        public PartRepository(RepositoryPatternContext context) : 
            base(context) {}

        public RepositoryPatternContext RepositoryPatternContext
        {
            get { return Context as RepositoryPatternContext; }
        }

        public IEnumerable<Part> GetPartsByProductId(int productId)
        {
            return RepositoryPatternContext.Parts.Where(n => n.ProductId == productId).ToList();
        }
    }
}
