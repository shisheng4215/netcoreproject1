using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2019113001.Data;

namespace WebApplication2019113001.Features.Users
{
    [Authorize]
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        private readonly EcommerceContext _db;
        public UsersController(EcommerceContext db)
        {
            _db = db;
        }

        [EnableCors]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _db.Users.ToListAsync());
        }

        [EnableCors]
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok(await _db.Users.ToListAsync());
        }
    }
}
