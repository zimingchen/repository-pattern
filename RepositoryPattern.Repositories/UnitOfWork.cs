using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryPatternContext _context;

        public UnitOfWork()
        {
            _context = new RepositoryPatternContext();
            Projects = new ProjectRepository(_context);
            Products = new ProductRepository(_context);
            Parts = new PartRepository(_context);
        }


        public IProjectRepository Projects { get; private set; }

        public IProductRepository Products { get; private set; }

        public IPartRepository Parts { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();            
        }
    }
}
