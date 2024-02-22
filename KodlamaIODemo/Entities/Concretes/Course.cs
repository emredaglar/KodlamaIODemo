using KodlamaIODemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Entities.Concretes
{
    public class Course : IEntitiy
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public string CourseDescription { get; set; }
        public int CoursePrice { get; set; }

        public int CourseInstructor { get; set; }

    }
}
