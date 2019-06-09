using GraphQL_Demo.Data;
using GraphQL_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GraphQL_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private StudentRepository studentRepo = new StudentRepository();

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get() => Ok(studentRepo.GetStudents());

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(String ID) => studentRepo.GetStudent(ID);

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Student Value) => studentRepo.AddStudent(Value);

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(String ID, [FromBody] Student Value) => studentRepo.UpdateStudent(ID, Value);

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(String ID) => studentRepo.RemoveStudent(ID);
    }
}
