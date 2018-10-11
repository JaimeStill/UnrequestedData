using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnrequestedData.Data;

namespace UnrequestedData.Web.Extensions
{
    public static class ItemExtensions
    {
        public static async Task<List<Item>> GetItems(this AppDbContext db)
        {
            var items = await db.Items
                .Include(x => x.Category)
                .OrderBy(x => x.Name)
                .ToListAsync();

            return items;
        }

        public static async Task<List<Item>> GetMinimalItems(this AppDbContext db)
        {
            var items = await db.Items
                .Include(x => x.Category)
                .OrderBy(x => x.Name)
                .ToListAsync();

            Parallel.ForEach(items, i =>
            {
                i.Category.Items = null;
            });

            return items;
        }
    }
}
