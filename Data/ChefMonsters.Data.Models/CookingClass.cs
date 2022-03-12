namespace ChefMonsters.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static ChefMonsters.Data.Models.Constants.DataModelsConstants;

    public class CookingClass : BaseDeletableModel<int>
    {
        public CookingClass()
        {
            this.Images = new HashSet<Image>();
            this.CookingClassInstances = new HashSet<CookingClassInstance>();
        }

        [Required]
        [MaxLength(CookingClassNameMaxLength)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int FoodThemeId { get; set; }

        public virtual FoodTheme FoodTheme { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<CookingClassInstance> CookingClassInstances { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }
    }
}
