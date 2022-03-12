namespace ChefMonsters.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChefMonsters.Data.Models;

    public class FoodThemeSeeder : ISeeder
    {
        public async Task SeedAsync(ChefMonstersDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.FoodThemes.Any())
            {
                return;
            }

            await dbContext.FoodThemes.AddAsync(new FoodTheme { Name = "Baking" });
            await dbContext.FoodThemes.AddAsync(new FoodTheme { Name = "Vegan and vegetarian" });
            await dbContext.FoodThemes.AddAsync(new FoodTheme { Name = "Desserts" });
            await dbContext.FoodThemes.AddAsync(new FoodTheme { Name = "Fish and seafood" });
            await dbContext.FoodThemes.AddAsync(new FoodTheme { Name = "Meat" });

            await dbContext.SaveChangesAsync();
        }
    }
}
