﻿using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2019113001.Infrastructure
{
    public class FeatureLocationExpander : IViewLocationExpander
    {
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            return new[] {"/Features/{1}/{0}.cshtml",
                            "/Features/Shared/{0}.cshtml"};
        }

        public void PopulateValues(ViewLocationExpanderContext context)
        {
           
        }
    }
}
