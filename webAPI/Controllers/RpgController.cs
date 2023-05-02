using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPI.Services;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RpgController : ControllerBase
    {
        private RpgServices _services;

        public RpgController()
        {
            _services = new RpgServices();
        }

        [HttpGet]
        [Route(template:"{id}")]
        public Rpg Get(int id)
        {
            Rpg result = null;
            
            result = _services Get(id);
            
            return result;
        }

        [HttpPost]
        public Rpg Post(Rpg rpg)
        {
            Rpg result = null;
            result = _services.Create(rpg);
            return result;
        }
    }
}
