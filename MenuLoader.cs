using System.Collections.Generic;
using cart.Data;
using cart.Models;
using System.Linq;

namespace cart
{
    public class  MenuLoader
    {
        public static void LoadMenus(MenuContext ctx)
        {
            // First - remove all menus from the DB
            ctx.Menus.RemoveRange(ctx.Menus);

            // Now - create list of menus
            var menus = new List<Menu>
            {
                new Menu{ID=1,Name="Classic Burger", Description="Classic burger with cheese and fresh vegetables.",ImageUrl="https://rhubarbandcod.com/wp-content/uploads/2022/06/The-Classic-Cheeseburger-1.jpg", InStock=54, Price=44.23 },
                new Menu{ID=2,Name="Chicken Sandwich", Description="Crispy chicken sandwich with lettuce and mayo.", ImageUrl="https://somethingaboutsandwiches.com/wp-content/uploads/2022/02/bacon-chicken-sandwich.jpg", InStock=13, Price=50.99 },
                new Menu{ID=3,Name="French Fries", Description="Golden French fries perfection", ImageUrl="https://www.vegrecipesofindia.com/wp-content/uploads/2021/04/french-fries-recipe-1.jpg", InStock=65, Price=18.97 },
                new Menu{ID=4,Name="Vegetables salad", Description="Fresh salad with assorted vegetables and light dressing",ImageUrl="https://www.corriecooks.com/wp-content/uploads/2023/05/Garden-Salad.jpg", InStock=15, Price=87.00 }
            };

            // Add the menu to the context
            ctx.Menus.AddRange(menus);

            // Save changes to the DB
            ctx.SaveChanges();
            System.Console.WriteLine($"Loaded {ctx. Menus.Count()} menus");
        }
    }
}