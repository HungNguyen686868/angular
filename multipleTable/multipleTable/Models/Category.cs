using multipleTable.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace multipleTable.Models
{
    public class Category
    {
        public Category()
        {
            Id = 1;
            Name = "Hung";
            SortOrder = 1;
            IsShowOnHome = false;
            Status = Status.Active;
        }
        public int Id { set; get; }
        public string Name { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public Status Status { set; get; }
    }
}
