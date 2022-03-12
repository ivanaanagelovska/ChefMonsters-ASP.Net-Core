namespace ChefMonsters.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChefMonsters.Data.Models;

    public class DifficultiesSeeder : ISeeder
    {
        public async Task SeedAsync(ChefMonstersDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Difficulties.Any())
            {
                return;
            }

            await dbContext.Difficulties.AddAsync(new Difficulty { Name = "Super easy" });
            await dbContext.Difficulties.AddAsync(new Difficulty { Name = "Not too tricky" });
            await dbContext.Difficulties.AddAsync(new Difficulty { Name = "Showing off" });

            await dbContext.SaveChangesAsync();
        }
    }
}
