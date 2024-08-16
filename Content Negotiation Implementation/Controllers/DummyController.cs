using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Net.Mime;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Content_Negotiation_Implementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DummyController : ControllerBase
    {
        // GET: api/<DummyController>
        [HttpGet]
        [Consumes(MediaTypeNames.Text.Plain)]
        public ActionResult<List<Employee>> GetEmployees()
        {
            var listEmployees = new List<Employee>()
            {
                new Employee(){ Id = 1001, Name = "Anurag", Age = 28, Gender = "Male", Department = "IT" },
                new Employee(){ Id = 1002, Name = "Pranaya", Age = 28, Gender = "Male", Department = "IT" },
            };
            return Ok(listEmployees);
            //return listEmployees;
        }

        // GET api/<DummyController>/5
        [HttpGet("check text")]
        public string Get()
        {
            return "Hello World";
        }

        // POST api/<DummyController>
        [HttpGet("verify")]
        public ContentResult Verify()
        {
            var html = "<div>Your account has been verified.</div>";
            return base.Content(html, "text/html");
        }

        // PUT api/<DummyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DummyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
