using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndecisiveApp.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
