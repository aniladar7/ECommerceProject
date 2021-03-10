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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category entity)
        {
            entity.Id = Guid.NewGuid();
            _categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            entity.Status = Entity.Enum.Status.Deleted;
            Update(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _categoryDal.Get(filter);
        }

        public List<Category> GetActive()
        {
            return _categoryDal.GetList(x => x.Status == Entity.Enum.Status.Active);
        }

        public List<Category> GetList(Expression<Func<Category, bool>> filter = null)
        {
            return _categoryDal.GetList(filter);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
