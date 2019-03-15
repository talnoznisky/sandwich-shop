using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SandwichShop.Data
{
    public static class MockData
    {
        public static Category[] categories =
        {
            new Category
            {
                ID = 1,
                Type = "Chicken Sandwiches",
                Description = "Fried, breaded, or grilled."
            },
            new Category
            {
                ID = 2,
                Type = "Beef Sandwiches",
                Description = "Sliced, brined, and beyond."
            },
            new Category
            {
                ID = 3,
                Type = "Veggie Sandwiches",
                Description = "Save the planet."
            }
    };

    }

}
