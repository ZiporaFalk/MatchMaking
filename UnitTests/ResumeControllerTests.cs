using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Controllers;

namespace UnitTests
{
    public class ResumeControllerTests
    {
        [Fact]
        public void GetAll_returnListOfResume()
        {
            //arrange
            //act
            var controller = new ResumeController();
            var result = controller.Get();
            //assert
            Assert.IsType<List<Resume>>(result);
        }
        [Fact]
        public void GetById_returnsOk()
        {
            var id = 1;
            var controller = new ResumeController();
            var result=controller.Get(id);
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetById_returnsNotFound()
        {

            var id = 5;
            var controller = new ResumeController();
            var result=controller.Get(id);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
