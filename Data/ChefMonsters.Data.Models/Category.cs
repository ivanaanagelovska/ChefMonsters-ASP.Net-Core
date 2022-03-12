namespace ChefMonsters.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static ChefMonsters.Data.Models.Constants.DataModelsConstants;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Recipes = new HashSet<Recipe>();
            this.Videos = new HashSet<Video>();
        }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}
