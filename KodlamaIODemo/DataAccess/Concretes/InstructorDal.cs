using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concretes
{
    public class InstructorDal:IInstructorDal
    {
        public void Add(Instructor instructor)
        {
            Console.WriteLine("Eğitmen Eklendi");
        }

        public void Delete(Instructor instructory)
        {
            Console.WriteLine("Eğitmen Silindi");
        }

        public void Uptade(Instructor instructor)
        {
            Console.WriteLine("Eğitmen Güncellendi");
        }
    }
}
