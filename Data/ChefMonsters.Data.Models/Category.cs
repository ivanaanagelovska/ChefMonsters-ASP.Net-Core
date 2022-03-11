namespace ChefMonsters.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static DataModelsConstants;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Recipes = new HashSet<Recipe>();
        }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
