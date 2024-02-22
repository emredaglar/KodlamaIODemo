using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstract
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Delete(Course course);
        void Uptade(Course course);
        
    }
}
