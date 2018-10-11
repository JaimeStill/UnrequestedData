using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnrequestedData.Data;
using UnrequestedData.Web.Extensions;

namespace UnrequestedData.Web.Controllers
{
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private AppDbContext db;

        public ItemController(AppDbContext db)
        {
            this.db = db;
        }

        [HttpGet("[action]")]
        public async Task<List<Item>> GetItems() => await db.GetItems();

        [HttpGet("[action]")]
        public async Task<List<Item>> GetMinimalItems() => await db.GetMinimalItems();
    }
}
