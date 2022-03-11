namespace ChefMonsters.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static DataModelsConstants;

    public class Ingredient : BaseDeletableModel<int>
    {
        public Ingredient()
        {
            this.Recipes = new HashSet<RecipeIngredient>();
        }

        [Required]
        [MaxLength(IngredientNameMaxLenghth)]
        public string Name { get; set; }

        public virtual ICollection<RecipeIngredient> Recipes { get; set; }
    }
}
