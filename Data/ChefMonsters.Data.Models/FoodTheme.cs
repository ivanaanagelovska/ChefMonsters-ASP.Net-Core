namespace ChefMonsters.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static ChefMonsters.Data.Models.Constants.DataModelsConstants;

    public class FoodTheme : BaseDeletableModel<int>
    {
        public FoodTheme()
        {
            this.CookingClasses = new HashSet<CookingClass>();
        }

        [Required]
        [MaxLength(FoodThemeMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<CookingClass> CookingClasses { get; set; }
    }
}
