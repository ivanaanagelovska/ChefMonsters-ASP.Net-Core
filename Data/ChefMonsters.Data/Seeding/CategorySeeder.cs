namespace ChefMonsters.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChefMonsters.Data.Models;

    public class CategorySeeder : ISeeder
    {
        public async Task SeedAsync(ChefMonstersDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "Vegetarian" });
            await dbContext.Categories.AddAsync(new Category { Name = "Gluten-free" });
            await dbContext.Categories.AddAsync(new Category { Name = "Vegan" });
            await dbContext.Categories.AddAsync(new Category { Name = "Dairy-free" });

            await dbContext.SaveChangesAsync();
        }
    }
}
