using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Concretes
{
    public class CategoryManager : ICategoryManager
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) {
            _categoryDal = categoryDal;
        
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void Uptade(Category category)
        {
            _categoryDal.Uptade(category);
        }

        
    }
}
