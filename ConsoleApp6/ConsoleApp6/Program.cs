namespace ConsoleApp6
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                var students = new List<Student>
{
    new Student { Id = 1, Name = "Ahmed Ali", Age = 21, Department = "CS", GPA = 3.6 },
    new Student { Id = 2, Name = "Sara Mohamed", Age = 20, Department = "IT", GPA = 3.2 },
    new Student { Id = 3, Name = "Omar Hassan", Age = 22, Department = "CS", GPA = 2.8 },
    new Student { Id = 4, Name = "Mona Adel", Age = 19, Department = "IS", GPA = 3.9 },
    new Student { Id = 5, Name = "Youssef Kamal", Age = 23, Department = "CS", GPA = 2.4 },
    new Student { Id = 6, Name = "Aya Mostafa", Age = 21, Department = "IT", GPA = 3.5 },
    new Student { Id = 7, Name = "Hassan Mahmoud", Age = 24, Department = "IS", GPA = 1.9 },
    new Student { Id = 8, Name = "Nada Fathy", Age = 20, Department = "CS", GPA = 3.1 },
    new Student { Id = 9, Name = "Ali Samir", Age = 18, Department = "IT", GPA = 2.6 },
    new Student { Id = 10, Name = "Reem Tarek", Age = 22, Department = "IS", GPA = 3.7 },
    new Student { Id = 11, Name = "Amr Nabil", Age = 21, Department = "CS", GPA = 4.0 },
    new Student { Id = 12, Name = "Laila Ashraf", Age = 19, Department = "IT", GPA = 2.2 }
};


                var courses = new List<Course>
 {
     new Course { Id = 1, Title = "C# Fundamentals", Credits = 3 },
     new Course { Id = 2, Title = "OOP", Credits = 4 },
     new Course { Id = 3, Title = "Databases", Credits = 3 },
     new Course { Id = 4, Title = "ASP.NET MVC", Credits = 4 },
     new Course { Id = 5, Title = "LINQ Deep Dive", Credits = 2 }
 };



                var enrollments = new List<Enrollment>
{
    new Enrollment { StudentId = 1, CourseId = 1 },
    new Enrollment { StudentId = 1, CourseId = 2 },

    new Enrollment { StudentId = 2, CourseId = 1 },
    new Enrollment { StudentId = 2, CourseId = 3 },

    new Enrollment { StudentId = 3, CourseId = 2 },

    new Enrollment { StudentId = 4, CourseId = 4 },
    new Enrollment { StudentId = 4, CourseId = 5 },

    new Enrollment { StudentId = 6, CourseId = 3 },
    new Enrollment { StudentId = 6, CourseId = 4 },

    new Enrollment { StudentId = 8, CourseId = 1 },

    new Enrollment { StudentId = 10, CourseId = 2 },
    new Enrollment { StudentId = 10, CourseId = 3 },

    new Enrollment { StudentId = 11, CourseId = 5 }
};




            //var q1 = students.Select(x => x.Name).ToList();
            //foreach (var item in q1)
            //{
            //    Console.WriteLine(item);
            //}


            //var q2 = students.Select(students => new Student
            //{
            //    Name = students.Name,
            //    GPA = students.GPA,
            //}
            //);

            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}




            //var q3 = students.Any(x => x.GPA > 3.8);
            //Console.WriteLine(q3);




            //var q4 = students.All(x => x.Age > 18);
            //Console.WriteLine(q4);



            //var q5 = students.Where(x => x.Age > 20).Select(x=> x.Name).ToList();
            //foreach (var item in q5)
            //{
            //    Console.WriteLine(item);
            //}



            //var q6 = students.Where(x=>x.Department == "CS").ToList();
            //foreach (var item in q6)
            //{
            //    Console.WriteLine(item);
            //}



            //var q7 = students.Select(x => new 
            //{
            //   Name = x.Name,
            //   Departement = x.Department
            //}).ToList();

            //foreach (var item in q7)
            //{
            //    Console.WriteLine(item);
            //}



            //var q8 = students.OrderBy(x=>x.GPA).ToList();
            //foreach (var item in q8)
            //{
            //    Console.WriteLine(item);
            //}



            //var q9 = students.OrderByDescending(x => x.GPA).ToList();
            //foreach (var item in q9)
            //{
            //    Console.WriteLine(item);
            //}


            //var q10 = students.OrderByDescending(x=>x.GPA).Take(5);
            //foreach (var item in q10)
            //{
            //    Console.WriteLine(item);
            //}



            //var q11 = students.All(x => x.GPA > 2.0);
            //Console.WriteLine(q11);


            //var q12 = students.Count();
            //Console.WriteLine(q12);





            //var q13 = students.Where(x => x.Name.Length > 5).ToList();
            //foreach(var student in q13)
            //{
            //    Console.WriteLine( student);
            //}



            //var q14 = students.Count();
            //Console.WriteLine(q14);




            //var q15 = students.Max(x => x.GPA);
            //Console.WriteLine(q15);



            //var q16 = students.Min(x => x.GPA);
            //Console.WriteLine(q16);



            //var q17 = students.Average(x => x.GPA);
            //Console.WriteLine(q17);



            //var q18 = students.Where(x => x.Department == "CS").Average(x => x.GPA);
            //Console.WriteLine(q18);



            //var q19 = students.Sum(x => x.GPA);
            //Console.WriteLine(q19);


            //var avg = students.Average(s => s.GPA);
            //var q20 = students.Count(s => s.GPA > avg);
            //Console.WriteLine(q20);



            //var q21 = students.OrderByDescending(x => x.Department == "CS").Take(3).Average(x => x.GPA);
            //Console.WriteLine(q21);



            //var q22 = students.OrderBy(x => x.Department).Skip(2).Average(x => x.GPA);
            //Console.WriteLine(q22);




            //var q23 = students.OrderByDescending(s => s.GPA);
            //foreach( var student in q23)
            //{
            //    Console.WriteLine(student);
            //}




            //var q24 = students.Count() > 20;
            //Console.WriteLine(q24);




            //var q25 = students.GroupBy(s => s.Department).Select(g => new
            //{
            //    DepartmentName = g.Key,
            //    StudentCount = g.Count()


            //}
            //);
            //foreach ( var student in q25)
            //{
            //    Console.WriteLine(student);
            //}




            //var q25 = students.GroupBy(s => s.Department).Select(g => new
            //{
            //    DepartmentName = g.Key,
            //    StudentCount = g.Average(x=>x.GPA)


            //}
            //);
            //foreach (var student in q25)
            //{
            //    Console.WriteLine(student);
            //}





            //var q26 = students.GroupBy(x => x.GPA > 3.5 ? "High" : x.GPA >= 2.5 ? "Medium" : "Low").ToList();
            //foreach (var item in q26)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach(var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}



            //var q27 = students .Join(enrollments,
            //student => student.Id,
            //enrollment => enrollment.StudentId,
            //(student, enrollment) => new { student, enrollment }).Join(courses,
            //se => se.enrollment.CourseId,
            //course => course.Id,
            //(se, course) => new
            //{
            //    StudentName = se.student.Name,
            //    CourseTitle = course.Title
            //});

            //foreach (var item in q27)
            //{
            //    Console.WriteLine($"{item.StudentName} - {item.CourseTitle}");
            //}














            //var q30 = students .GroupBy(s => s.Department).Select(g => new
            //{
            //    Department = g.Key,
            //    HighestGPA = g.Max(s => s.GPA)
            //});


            //foreach (var student in q30)
            //{
            //    Console.WriteLine(student);
            //}


            //var q31 = students.GroupBy(s => s.Department).Select(g => new
            //{
            //    Department = g.Key,
            //    AvgGPA = g.Average(s => s.GPA)
            //}).OrderByDescending(x => x.AvgGPA);

            //foreach (var item in q31)
            //{
            //    Console.WriteLine($"{item.Department}  Avg : {item.AvgGPA}");
            //}

        }
    }
    
}
