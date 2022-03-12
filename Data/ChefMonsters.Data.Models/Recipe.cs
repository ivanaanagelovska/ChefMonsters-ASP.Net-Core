namespace ChefMonsters.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static ChefMonsters.Data.Models.Constants.DataModelsConstants;

    public class Recipe : BaseDeletableModel<int>
    {
        public Recipe()
        {
            this.Ingredients = new HashSet<RecipeIngredient>();
            this.Images = new HashSet<Image>();
        }

        [Required]
        [MaxLength(RecipeNameMaxLenghth)]
        public string Name { get; set; }

        [MaxLength(RecipeDescriptionMaxLenghth)]
        public string Description { get; set; }

        public int Serves { get; set; }

        public TimeSpan PreparationTime { get; set; }

        public TimeSpan CookingTime { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int DifficultyId { get; set; }

        public Difficulty Difficulty { get; set; }

        [Required]
        public string Method { get; set; }

        public string Tips { get; set; }

        public virtual ICollection<RecipeIngredient> Ingredients { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }
    }
}
