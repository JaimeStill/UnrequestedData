using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnrequestedData.Data;

namespace UnrequestedData.Web.Extensions
{
    public static class DbInitializer
    {
        public static void Initialize(this AppDbContext db)
        {
            db.Database.EnsureCreated();

            if (!db.Categories.Any())
            {
                var categories = new List<Category>()
                {
                    new Category { Name = "Category A" },
                    new Category { Name = "Category B" },
                    new Category { Name = "Category C" }
                };

                db.Categories.AddRange(categories);
                db.SaveChanges();
            }

            if (!db.Items.Any())
            {
                var items = new List<Item>()
                {
                    new Item { Name = "Item A", CategoryId = 1 },
                    new Item { Name = "Item B", CategoryId = 1 },
                    new Item { Name = "Item C", CategoryId = 1 },
                    new Item { Name = "Item D", CategoryId = 2 },
                    new Item { Name = "Item E", CategoryId = 2 },
                    new Item { Name = "Item F", CategoryId = 2 },
                    new Item { Name = "Item G", CategoryId = 3 },
                    new Item { Name = "Item H", CategoryId = 3 },
                    new Item { Name = "Item I", CategoryId = 3 }
                };

                db.Items.AddRange(items);
                db.SaveChanges();
            }
        }
    }
}
