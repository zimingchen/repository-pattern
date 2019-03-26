using RepositoryPattern.Data;
using RepositoryPattern.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryPattern.Repository1
{
    public class ProjectRepository1 : IGetable, IUpdatable
    {
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectTypeId { get; set; }

        public void Get(RepositoryPatternContext context)
        {
            var projectId = ProjectId.GetValueOrDefault();
            var project = context.Projects.FirstOrDefault(n => n.ProjectId == projectId);

            ProjectName = project.ProjectName;
            ProjectTypeId = project.ProjectTypeId.GetValueOrDefault();
        }

        public void Update(RepositoryPatternContext context)
        {
            var projectId = ProjectId.GetValueOrDefault();
            var project = context.Projects.FirstOrDefault(n => n.ProjectId == projectId);

            if (project == null) throw new Exception($"Invalid ProjectId: {ProjectId}");

            project.ProjectName = ProjectName;
            project.ProjectTypeId = ProjectTypeId;
        }
    }
}
