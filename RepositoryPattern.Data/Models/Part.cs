using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Data.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public int ProductId { get; set; }
        public string PartName { get; set; }
        public string PartCode { get; set; }
    }
}
