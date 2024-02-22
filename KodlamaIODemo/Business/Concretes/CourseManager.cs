using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.DataAccess.Concretes;
using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Concretes
{
    public class CourseManager : ICourseManager
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {

            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

     

        public void Uptade(Course course)
        {
            _courseDal.Uptade(course);
        }
    }
}
