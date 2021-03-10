using Core.Entity.Abstract;
using Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Category:IEntity
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }
        public List<Product> Products { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
