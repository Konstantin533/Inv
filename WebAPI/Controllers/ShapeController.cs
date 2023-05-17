using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShapeController : ControllerBase
    {

        public ShapeController()
        {
        }

        /// <summary> Возвращает рандомное количество разных фигур  </summary>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet(Name = "RandomShape")]
        public IEnumerable<Shape> Get()
        {
            var random = new Random();
            List<Shape> shapes = Helper.GenerateRandomShape(random.Next(1, 25));
            return shapes;
        }
           

    }
}

