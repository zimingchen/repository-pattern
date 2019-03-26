using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProjectId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductType { get; set; }
        public DateTime? ProductUpdatedTime { get; set; }
        public string ProductStatusType { get; set; }
    }
}
