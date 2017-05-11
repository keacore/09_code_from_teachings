using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWebApi.Model.Entities;
using TodoWebApi.Model.Repositories;

namespace TodoWebApi.Controllers
{
    [Route("api/[controller]")]
    public class TodosController : Controller
    {
        private ITodoRepository _todoRepository;

        //Tightly Coupled
        //List<TodoItem> _todoList = new List<TodoItem>();

        public TodosController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }


        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var todos = _todoRepository.GetAll();
            return new OkObjectResult(todos);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            //return NotFound();
            return new OkObjectResult(_todoRepository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
