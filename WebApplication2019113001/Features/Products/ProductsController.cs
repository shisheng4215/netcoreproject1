using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2019113001.Data;

namespace WebApplication2019113001.Features.Products
{
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
        private readonly EcommerceContext _db;

        public ProductsController(EcommerceContext db)
        {
            _db = db;
        }

        [HttpGet]
        [EnableCors]
        public async Task<IActionResult> Find()
        {
            var products = await _db.Products.ToListAsync();

            return Ok(products);
        }

        [HttpGet("{slug}")]
        [EnableCors]
        public async Task<IActionResult> Get(string slug)
        {
            var product = await _db.Products.SingleOrDefaultAsync(x => x.Slug == slug);
            if (product == null)
                return NotFound();
            return Ok(product);
        }


    }
}
