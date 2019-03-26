using RepositoryPattern.Data;
using RepositoryPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryPattern.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(RepositoryPatternContext context) : base(context) { }

        public RepositoryPatternContext RepositoryPatternContext
        {
            get { return Context as RepositoryPatternContext; }
        }

        public Project GetLastAdded()
        {
            return RepositoryPatternContext.Projects.OrderByDescending(n => n.ProjectId).FirstOrDefault();
        }
    }
}
