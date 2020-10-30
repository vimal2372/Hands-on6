using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dockersampleconfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return new List<MenuItem> {new MenuItem()
                {
                    Id = 1,
                    Name = "Chicken"
                    
                },
            new MenuItem()
                {
                    Id = 2,
                    Name = "Soup"
                   
                }};
        }
    }
}



