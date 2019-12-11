using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2019113001.Data.Entites;

namespace WebApplication2019113001.Data
{
    public static class DbContextExtentions
    {
        public static UserManager<AppUser> UserManager { get; set; }

        public static void EnsureSeeded(this EcommerceContext context)
        {
            if (UserManager.FindByEmailAsync("stu@ratcliffe.io").GetAwaiter().GetResult() == null)
            {
                var user = new AppUser
                {
                    FirstName = "Stu",
                    LastName = "Ratcliffe",
                    UserName = "stu@ratcliffe.io",
                    Email = "stu@ratcliffe.io",
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };

                UserManager.CreateAsync(user, "Password1*").GetAwaiter().GetResult();
            }

            AddProducts(context);
        }
        private static void AddProducts(EcommerceContext context)
        {
            if (context.Products.Any() == false)
            {
                var products = new List<Product>()
                {
                    new Product
                    {
                        Name="Samsung Galaxy S8",
                        Slug="samsung-galaxy-s8",
                        Thumbnail="http://localhost:8080/samsung-s8.jpg",
                        ShortDescription="Samsung Galaxy S8 Android smartphone with true edge to edge display",
                        Description="Lorem ipsum dolor sitamet consectetur adipisicing elit.Perferendistempora ad cum laudantium",
                        Price=499.99M

                    },
                    new Product
                    {
                        Name="Apple X",
                        Slug="apple-x",
                        Thumbnail="http://localhost:8080/apple-x.jpg",
                        ShortDescription="Apple IOS smartphone ",
                        Description="fdafdafdafdafd fdafdafds apple apple apple apple ora ad cum laudantium",
                        Price=599.99M

                    },
                     new Product
                    {
                        Name="Huawei P30",
                        Slug="huawei-p30",
                        Thumbnail="http://localhost:8080/p30.png",
                        ShortDescription="华为 P30 智能手机 smartphone ",
                        Description="华为 P30 dfdafdafdafdafdafdafdafdafdafda",
                        Price=399.99M

                    },
                      new Product
                    {
                        Name="小米9",
                        Slug="xiaomi-9",
                        Thumbnail="http://localhost:8080/mi9.jpg",
                        ShortDescription="小米9 智能手机 smartphone ",
                        Description="小米9 ssssssssssdfwwwwwwwwwwqqqqqqqqqqqqqqqdfdafdafdafdafdafdafdafdafdafda",
                        Price=299.99M

                    }
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }

    }
}
