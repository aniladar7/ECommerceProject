using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product entity)
        {
            entity.Id = Guid.NewGuid();
            _productDal.Add(entity);
        }

        public void Delete(Product entity)
        {
            entity.Status = Entity.Enum.Status.Deleted;
            Update(entity);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return _productDal.Get(filter);
        }

        public List<Product> GetActive()
        {
            return _productDal.GetList(x => x.Status == Entity.Enum.Status.Active);
        }

        public List<Product> GetList(Expression<Func<Product, bool>> filter = null)
        {
            return _productDal.GetList(filter);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
