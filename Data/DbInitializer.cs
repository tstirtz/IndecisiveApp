using IndecisiveApp.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace IndecisiveApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IndecisiveContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Categories.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
            new Category{Title="Restaurants", ID=1},
            new Category{Title="Moveies", ID=2},
            new Category{Title="Shows", ID=3},

            };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var items = new Item[]
            {
            new Item{ID=1,CategoryID=1,Title="Chik-fil-A"},
            new Item{ID=2,CategoryID=1,Title="Wendy's"},
            new Item{ID=3,CategoryID=1,Title="Butchers Union"},
            new Item{ID=4,CategoryID=2,Title="Gladiotor"},
            new Item{ID=5,CategoryID=2,Title="The Empire Strike Back"},
            new Item{ID=6,CategoryID=2,Title="End Game"},
            new Item{ID=7,CategoryID=3,Title="Game of Thrones"},
            new Item{ID=8,CategoryID=3,Title="Friends"},
            new Item{ID=9,CategoryID=3,Title="Parks and Recreation"},
            };
            foreach (Item i in items)
            {
                context.Items.Add(i);
            }
            context.SaveChanges();

            var tags = new Tag[]
{
            new Tag{ID=1,ItemID=1,Title="Fast Food"},
            new Tag{ID=2,ItemID=2,Title="Fast Food"},
            };
            foreach (Tag t in tags)
            {
                context.Tags.Add(t);
            }
            context.SaveChanges();
        }
    }
}
