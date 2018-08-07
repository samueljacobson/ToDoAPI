using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAPI.Controllers;
using ToDoAPI.Models;

namespace ToDoAPI.Tests
{
    [TestFixture]
    public class ToDoControllerTests
    {
        //[Test]
        //public void Test()
        //{
        //    Assert.Fail();
        //}

        [Test]
        public void GetAll_Returns_A_List_Of_ToDos()
        {
            var controller = new ToDoController();
            var result = controller.GetAll();
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void Post_Saves_ToDo()
        {
            var todo = new ToDo();
            var controller = new ToDoController();

            controller.Post(todo);

            var result = controller.GetAll();

            Assert.That(result.Count, Is.EqualTo(2));
        }
    }
}
