namespace ChefMonsters.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static DataModelsConstants;

    public class Difficulty : BaseDeletableModel<int>
    {
        public Difficulty()
        {
            this.Recipes = new HashSet<Recipe>();
        }

        [Required]
        [MaxLength(DifficultyNameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
