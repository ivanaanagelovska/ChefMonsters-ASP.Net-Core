namespace ChefMonsters.Services.Data.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ChefMonsters.Data;
    using ChefMonsters.Data.Common.Repositories;
    using ChefMonsters.Data.Models;
    using ChefMonsters.Data.Repositories;

    using Microsoft.EntityFrameworkCore;

    using Moq;

    using Xunit;

    public class SettingsServiceTests
    {
        [Fact]
        public async Task GetCountShouldReturnCorrectNumberUsingDbContext()
        {
            var options = new DbContextOptionsBuilder<ChefMonstersDbContext>()
                .UseInMemoryDatabase(databaseName: "SettingsTestDb").Options;
            using var dbContext = new ChefMonstersDbContext(options);
            await dbContext.SaveChangesAsync();
        }
    }
}
