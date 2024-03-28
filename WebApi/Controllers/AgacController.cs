using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AgacController : Controller
    {
        private readonly IAgacService _AgacService;

        public AgacController(IAgacService AgacService)
        {
            _AgacService = AgacService;
        }

        //getall
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_AgacService.GetAll());
        }

        
        [HttpPost]
        public IActionResult Add(Agac Agac)
        {
            Agac createdBrandResponse = _AgacService.Add(Agac);

            return Ok(Agac);
        }


    }
}

