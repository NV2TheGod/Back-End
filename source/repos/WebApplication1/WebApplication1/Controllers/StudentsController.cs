using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class StudentsController : ControllerBase
    {
        public static List<Students> GetStudents()
        {
            List<Students> students = new List<Students>();
            students.Add(new Students() { Id = 1, First_name = "Anton", Last_name = "Lafargue", Age = 19 });
            students.Add(new Students() { Id = 1, First_name = "Marin", Last_name = "Bailhe", Age = 20 });
            students.Add(new Students() { Id = 1, First_name = "Guilhem", Last_name = "Carlet", Age = 20 });
            students.Add(new Students() { Id = 1, First_name = "Nael", Last_name = "Valin", Age = 19 });
            students.Add(new Students() { Id = 1, First_name = "Julien", Last_name = "Matos", Age = 21 });
            return students;
        }
        [HttpGet]
        public IEnumerable<Students> GetStudents_List()
        {
            return GetStudents();
        }
        [HttpGet("{id}")]
        public ActionResult<Students> GetStudents_ById(int id)
        {
            var students = GetStudents().Find(x => x.Id == id);
            if (students != null)
            {
                return students;
            }
            else
            {
                return NotFound();
            }
        }
    }
}