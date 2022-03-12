namespace ChefMonsters.Data.Seeding
{
    using ChefMonsters.Data.Models;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public class ClassTypeSeeder : ISeeder
    {
        public async Task SeedAsync(ChefMonstersDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.ClassTypes.Any())
            {
                return;
            }

            await dbContext.ClassTypes.AddAsync(new ClassType { Name = "Onsite" });
            await dbContext.ClassTypes.AddAsync(new ClassType { Name = "Online" });

            await dbContext.SaveChangesAsync();
        }
    }
}
