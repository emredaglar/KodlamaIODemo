using KodlamaIODemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Entities.Concretes
{
    public class Category:IEntitiy
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
