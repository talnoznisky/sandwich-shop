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
                Description = "Fried, breaded, or grilled.",
                Image = "/images/chicken-tender.png",
                Products =
                {
                    new Product(){
                        Name = "Chicken BLT",
                        Image = "/images/chicken-blt.png",
                        ID = 1
                    },
                    new Product()
                    {
                        Name = "Grilled Chicken",
                        Image = "/images/chicken-grilled.png",
                        ID = 2

                    },
                    new Product()
                    {
                        Name = "Chicken Tender",
                        Image = "/images/chicken-tender.png",
                        ID = 3

                    }
                }

            },
            new Category
            {
                ID = 2,
                Type = "Beef Sandwiches",
                Description = "Sliced, brined, and beyond.",
                Image = "/images/beef-burger.png",
                Products =
                {
                    new Product(){
                        Name = "Burger",
                        Image = "/images/beef-burger.png",
                        ID = 4
                    },
                    new Product()
                    {
                        Name = "Meatballs",
                        Image = "/images/beef-meatball.png",
                        ID = 5

                    },
                    new Product()
                    {
                        Name = "Roast beef",
                        Image = "/images/beef-roastbeef.png",
                        ID = 6

                    }
                }
            },
            new Category
            {
                ID = 3,
                Type = "Veggie Sandwiches",
                Description = "Save the planet.",
                Image = "/images/veggie-cheese.png",
                Products =
                {
                    new Product(){
                        Name = "Cheese",
                        Image = "/images/veggie-cheese.png",
                        ID = 7
                    },
                    new Product()
                    {
                        Name = "Lettuce",
                        Image = "/images/veggie-lettuce.png",
                        ID = 8

                    },
                    new Product()
                    {
                        Name = "Sprouts",
                        Image = "/images/veggie-sprouts.png",
                        ID = 9

                    }
                }
            }
    };

    }

}
