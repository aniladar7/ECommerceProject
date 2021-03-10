using Core.Entity.Abstract;
using Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Product:IEntity
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string ImagePath { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
