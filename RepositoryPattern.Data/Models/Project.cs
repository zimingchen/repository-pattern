using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Data.Models
{
    public class Project
    {
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int? ProjectTypeId { get; set; }
        public int? ProjectStatusId { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? ProjectSupplierId { get; set; }
    }
}
