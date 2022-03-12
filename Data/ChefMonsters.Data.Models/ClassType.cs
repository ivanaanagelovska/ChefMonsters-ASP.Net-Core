namespace ChefMonsters.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChefMonsters.Data.Common.Models;

    using static ChefMonsters.Data.Models.Constants.DataModelsConstants;

    public class ClassType : BaseDeletableModel<int>
    {
        public ClassType()
        {
            this.CookingClassInstances = new HashSet<CookingClassInstance>();
        }

        [Required]
        [MaxLength(ClassTypeMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<CookingClassInstance> CookingClassInstances { get; set; }
    }
}
