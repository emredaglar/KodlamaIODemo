using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Abstract
{
    public interface ICourseManager
    {
        void Add(Course course);
        void Delete(Course course);
        void Uptade(Course course);

     
    }
}
