using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        public void Add(Category category)
        {
            Console.WriteLine("Kategori Eklendi");
        }

        public void Delete(Category category)
        {
            Console.WriteLine("Kategori Silindi");
        }

        public void Uptade(Category category)
        {
            Console.WriteLine("Kategori Güncellendi");
        }

       
    }
}
