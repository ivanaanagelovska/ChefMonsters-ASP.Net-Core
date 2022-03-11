namespace ChefMonsters.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static DataModelsConstants;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        [Required]
        [MaxLength(ImageExtentionMaxLenghth)]
        public string Extention { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }
    }
}
