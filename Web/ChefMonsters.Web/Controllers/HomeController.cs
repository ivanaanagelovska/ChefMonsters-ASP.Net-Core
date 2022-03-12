namespace ChefMonsters.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;

    using ChefMonsters.Data;
    using ChefMonsters.Web.ViewModels;
    using ChefMonsters.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ChefMonstersDbContext dbContext;

        public HomeController(ChefMonstersDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                CategoryCount = this.dbContext.Categories.Count(),
                ImagesCount = this.dbContext.Images.Count(),
                IngredientCount = this.dbContext.Ingredients.Count(),
                RecipeCount = this.dbContext.Recipes.Count(),
            };

            return this.View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
