using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Delete(Category category);
        void Uptade(Category category);
        

    }
}
