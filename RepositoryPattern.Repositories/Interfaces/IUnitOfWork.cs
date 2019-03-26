using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        IProductRepository Products { get; }
        IPartRepository Parts { get; }
        int Save();
    }
}
