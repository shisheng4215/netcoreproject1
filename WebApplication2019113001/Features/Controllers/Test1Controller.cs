using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2019113001.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test1Controller:Controller
    {
             public string Get()
        {
            return "api test";
        }
    }
}
