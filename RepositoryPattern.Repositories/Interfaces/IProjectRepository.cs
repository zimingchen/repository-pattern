using RepositoryPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        //void UpdateProjectStatus(int projectId, int statusId);
        //IEnumerable<Project> GetProjectByStatus(int[] statueIds);
        Project GetLastAdded();
    }
}
