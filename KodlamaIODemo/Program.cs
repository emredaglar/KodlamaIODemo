using KodlamaIODemo.Business.Concretes;
using KodlamaIODemo.DataAccess.Concretes;
using KodlamaIODemo.Entities.Concretes;


Category category1 = new Category();
category1.CategoryId = 1;
category1.CategoryName = "Programlama";

Course course1 = new Course();

course1.CourseId = 1;
course1.CourseName = "Java";
course1.CourseDescription = "Java Eğitimi";
course1.CoursePrice = 100;

Course course2 = new Course();
course1.CourseId = 2;
course2.CourseName = "C#";
course2.CourseDescription = "C# Eğitimi";
course2.CoursePrice = 200;


Instructor instructor1 = new Instructor();
instructor1.InstructorId = 1;
instructor1.FirstName = "Emre";
instructor1.LastName = "Dağlar";
instructor1.InstructorBio = "Bilgisayar Mühendisi";


//-------------------------------------------------------------------------------------------------------


Console.WriteLine("************** Category Runnig... **************");
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
categoryManager.Add(category1);
categoryManager.Uptade(category1);
categoryManager.Delete(category1);

List<Category> categories = new List<Category> { category1 };

foreach (var category in categories)
{
    Console.WriteLine("Category Name: " + category.CategoryName + " /n " + "Category Id: " + category.CategoryId);
}


//-------------------------------------------------------------------------------------------------------


Console.WriteLine("************** Course Runnig... **************");
CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.Add(course1);
courseManager.Delete(course1);
courseManager.Uptade(course1);



List<Course> courses = new List<Course> { course1, course2 };

//for (int i = 0; i < courses.Count; i++)
//{
//    Console.WriteLine(courses[i].CourseName);
//}

foreach (var course in courses)
{
    Console.WriteLine("Course Name: " + course.CourseName + "  " + "Course Id: " + course.CourseId + "  " + "Course Price" + course.CoursePrice);
}

//--------------------------------------------------------------------------------------    -----------------


Console.WriteLine("************** Instructer Runnig... **************");
InstructorManager instructorManager = new InstructorManager(new InstructorDal());
instructorManager.Add(instructor1);
instructorManager.Delete(instructor1);
instructorManager.Uptade(instructor1);

Console.WriteLine("Eğitmen Adı: "+  instructor1.FirstName + " " + instructor1.LastName);

