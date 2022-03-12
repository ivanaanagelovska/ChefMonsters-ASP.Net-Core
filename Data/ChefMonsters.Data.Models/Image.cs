namespace ChefMonsters.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static ChefMonsters.Data.Models.Constants.DataModelsConstants;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int? RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        public int? CookingClassId { get; set; }

        public virtual CookingClass CookingClass { get; set; }

        [Required]
        [MaxLength(ImageExtentionMaxLenghth)]
        public string Extention { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }
    }
}
