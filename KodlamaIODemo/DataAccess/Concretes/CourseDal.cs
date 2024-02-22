using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public void Add(Course course)
        {
            Console.WriteLine("Kurs Eklendi");
        }

        public void Delete(Course course)
        {
            Console.WriteLine("Kurs Silindi");
        }

       

        public void Uptade(Course course)
        {
            Console.WriteLine("Kurs Güncellendi");
        }
    }
}
