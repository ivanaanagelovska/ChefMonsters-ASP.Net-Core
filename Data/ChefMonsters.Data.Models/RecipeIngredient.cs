namespace ChefMonsters.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    public class RecipeIngredient : BaseDeletableModel<int>
    {
        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public int IngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        [Required]
        public string Quantity { get; set; }
    }
}
