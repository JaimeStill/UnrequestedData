using System;
using System.Collections.Generic;
using System.Text;

namespace UnrequestedData.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Item> Items { get; set; }
    }
}
