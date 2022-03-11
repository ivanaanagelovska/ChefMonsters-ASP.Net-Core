namespace ChefMonsters.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(ChefMonstersDbContext dbContext, IServiceProvider serviceProvider);
    }
}
