using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers
{
    public class ToDoController : ApiController
    {
        private static List<ToDo> todos = new List<ToDo>()
            {
                new ToDo() { Id = 1, Name = "Feed cat", Priority = 1}
            };

    public List<ToDo> GetAll()
        {
            return todos;
        }

        public void Post(ToDo todo)
        {
            todos.Add(todo);
        }
    }
}
