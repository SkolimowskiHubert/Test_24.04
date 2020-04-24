using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_24._04.Models;

namespace Test_24._04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetTeamMember()
        {
            var result = new List<TeamMember>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "select * from TeamMember";


            }
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetSemester(string id)
        {
            var result = new List<Task>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                
            }
            

            return Ok(result);
        }







        // POST: api/Task
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

      
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

       
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
