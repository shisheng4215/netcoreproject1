﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2019113001.Data.Entites;

namespace WebApplication2019113001.Data
{
    public class EcommerceContext:IdentityDbContext<AppUser,AppRole,int>
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options):base(options)
        {

        }
    }
}