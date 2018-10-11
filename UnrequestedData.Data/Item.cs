using System;
using System.Collections.Generic;
using System.Text;

namespace UnrequestedData.Data
{
    public class Item
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}
