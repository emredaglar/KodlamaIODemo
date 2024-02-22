using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(Instructor instructor);
        void Uptade(Instructor instructor);
    }
}
