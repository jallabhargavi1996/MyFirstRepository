using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Entites;
using MyFirstApp.Providers;

namespace MyFirstApp.Controllers
{
    [Route("api/studentController")]
    [ApiController]
    public class StudentController : ControllerBase
    {
       [Route("GETVALUES")]
        [HttpGet]
        public Student GetValues()
        {
            StudentDbContext studentDb = new StudentDbContext();
            Student ste = new Student();
            ste.Name = "lavanya";
            ste.Branch = "EEE";
            ste.Address = "Tpt";
            ste.MobileNo = 9573621788;
            studentDb.Students.Add(ste);
          studentDb.SaveChanges();
            return ste;


        }
       
        [HttpPost]
        public void InsertValues([FromBody] Student st)
        {
            StudentDbContext studentDb = new StudentDbContext();
            studentDb.Students.Add(st);
            studentDb.SaveChanges();
        }
       
         [HttpGet("{id}", Name = "GetStudents")]
         public Student GetStudents(int id)
        {
            StudentDbContext studentDb = new StudentDbContext();
            Student student = studentDb.Students.Where(c => c.Id == id).FirstOrDefault();
            return student;
            
        }

        

    }
}
