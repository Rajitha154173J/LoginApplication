using System;
using System.Collections.Generic;
using System.Linq;
using application.Data;
using application.Models;
using Microsoft.AspNetCore.Mvc;

namespace application.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;

            // if (_context.Users.Count() == 0)
            // {
            //     // Create a new TodoItem if collection is empty,
            //     // which means you can't delete all TodoItems.
            //     _context.Users.Add(new User { Id  = 1,UserName="Rajitha",Password="aaa" });
            //     _context.SaveChanges();
            // }
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll()
        {
            return _context.Users.ToList();
        }



        [HttpGet("{id}" ,Name="GetTodo")]
            public ActionResult<User> GetById(int id)
            {
                var item = _context.Users.Find(id);
                if (item == null)
                {
                    return NotFound();
                }
                return item;
                }

            [HttpPost]
            public IActionResult Create([FromBody]User data)
            {

          return Ok(data.UserName);
                // _context.Users.Add(data);
                // _context.SaveChanges();

                //  return CreatedAtRoute("GetTodo", new { id = data.Id }, data);
            }

    }
}
