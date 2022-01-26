using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCarProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        private ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result= _carService.GetAll();
            if(result.IsSuccess)
            return Ok(result);

            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
           var result= _carService.Add(car);
            if (result.IsSuccess)
                return Ok(result.Message);

            return BadRequest(result.Message);
        }

    }
}
