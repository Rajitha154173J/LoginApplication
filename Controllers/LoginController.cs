using System;
using System.Collections.Generic;
using System.Linq;
using application.Data;
using application.Models;
using Microsoft.AspNetCore.Mvc;

namespace application.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
          private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }

            [HttpPost]
            public IActionResult Create([FromBody]User data)
            {

             return Ok(Json(data.UserName));
                // _context.Users.Add(data);
                // _context.SaveChanges();

                //  return CreatedAtRoute("GetTodo", new { id = data.Id }, data);
            }
    }
}