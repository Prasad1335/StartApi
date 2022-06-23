using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StartApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PersonController : ControllerBase
    {
        [HttpGet("people/Getall")]
        public ActionResult<IEnumerable<Person>> GetAll()
        {
            return new[]
            {
            new Person { Name = "Shubham",Age = 22,Phone = 9876543212 },
            new Person { Name = "Sonali" ,Age = 23,Phone = 9876543212 },
            new Person { Name = "Tejas",Age = 23,Phone = 9876543212  }
        };
        }


        [HttpGet("people/one")]
        public ActionResult<IEnumerable<Person>> One()
        { 
            return GetAll();
        }


        [HttpGet("people/student")]
        public ActionResult<IEnumerable<Student>> Student()
        {
            return new[]
            {
            new Student {Id=1,StudentName = "Shubham",StudentAge = 22,StudentPhone = 986534533212,StudentEmail="Shubham@gmail.com",StudentClass="masters" },
            new Student {Id=2,StudentName = "Sonali",StudentAge = 20,StudentPhone = 9876534512 ,StudentEmail="Sonali@gmail.com",StudentClass="bachloer"},
            new Student {Id=2,StudentName = "Prasad",StudentAge = 21,StudentPhone = 9834543212 ,StudentEmail="Prasad@gmail.com",StudentClass="masters"},
            new Student {Id=4,StudentName = "Raj",StudentAge = 23,StudentPhone = 98763553212 ,StudentEmail="Raj@gmail.com",StudentClass="masters"},
            new Student {Id=5,StudentName = "Shreya",StudentAge = 22,StudentPhone = 9875353212,StudentEmail="Shreya@gmail.com",StudentClass="bachloer" },
            new Student {Id=6,StudentName = "Tejas",StudentAge = 22,StudentPhone = 987654532212 ,StudentEmail="Tejas@gmail.com",StudentClass="masters"},
            new Student {Id=7,StudentName = "Abhijit",StudentAge = 21,StudentPhone = 987352543212 ,StudentEmail="Abhijit@gmail.com",StudentClass="bachloer"},
            new Student {Id=8,StudentName = "Pandurang",StudentAge = 22,StudentPhone = 98755543212,StudentEmail="Pandurang@gmail.com",StudentClass="masters" },
            new Student {Id=9,StudentName = "Shweta",StudentAge = 25,StudentPhone = 987654532212,StudentEmail="Shweta@gmail.com",StudentClass="bachloer" },

        };
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public long StudentPhone { get; set; }
        public string StudentEmail { get; set; }
        public string StudentClass { get; set; }
    }
}
