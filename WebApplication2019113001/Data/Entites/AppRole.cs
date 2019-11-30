using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2019113001.Data.Entites
{
    public class AppRole:IdentityRole<int>
    {
        public AppRole()
        {

        }

        public AppRole(string name)
        {
            Name = name;
        }
    }
}
