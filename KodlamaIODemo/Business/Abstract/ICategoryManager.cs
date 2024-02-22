using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Abstract
{
    public interface ICategoryManager
    {
        void Add(Category category);
        void Delete(Category category);
        void Uptade(Category category);

       
    }
}
