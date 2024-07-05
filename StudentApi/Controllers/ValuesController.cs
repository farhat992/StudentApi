using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace StudentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //Student st1=new Student() { Name = "john", FatherName = "john doe", Dob = "xyz" };
        /*private static readonly List<Student> _products = new List<Student>()
   {
       new Student { Id = 1, Name = "john", FatherName = "john doe",Dob="xyz" },
       new Student { Id = 1, Name = "john", FatherName = "john doe",Dob="xyz"}

   };*/
        private DataAccessLayer _context=new DataAccessLayer();
       
        public ValuesController(DataAccessLayer context)
        {
            _context = context;
           _context.Students.AddRange(
                new Student() { Name = "john", FatherName = "john doe", Dob = "30feb" },
                new Student() { Name = "Alan", FatherName = "alan doe", Dob = "18feb" });
            _context.SaveChanges();

        }  
        [HttpGet]
        public async Task <IActionResult> GetAll()
        {
            var _products=await _context.Students.ToListAsync();
                                        
            return Ok(_products);
        }






    }
}
