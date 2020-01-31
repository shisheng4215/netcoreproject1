using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2019113001.Data;

namespace WebApplication2019113001.Features.Filters
{
    [Route("api/[controller]")]
    public class FiltersController : ControllerBase
    {
        private readonly EcommerceContext _db;

        public FiltersController(EcommerceContext db)
        {
            _db = db;
        }

        [HttpGet]
        [EnableCors]
        public async Task<IActionResult> Get()
        {
            var brands = await _db.Brands.Select(x => x.Name).ToListAsync();

            var storage = await _db.Storage.Select(x => x.Capacity.ToString()).ToListAsync();

            var colours = await _db.Colours.Select(x => x.Name).ToListAsync();

            var os = await _db.OS.Select(x => x.Name).ToListAsync();

            var features = await _db.Features.Select(x => x.Name).ToListAsync();

            return Ok(new FiltersListViewModel
            {
                Brands = brands,
                Storage = storage,
                Colours = colours,
                OS = os,
                Features = features
            });
        }
    }
}