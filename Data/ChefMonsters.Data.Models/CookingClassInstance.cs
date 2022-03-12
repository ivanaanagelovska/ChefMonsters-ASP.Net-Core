namespace ChefMonsters.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using ChefMonsters.Data.Common.Models;

    public class CookingClassInstance : BaseDeletableModel<int>
    {
        public DateTime DateTime { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int ClassTypeId { get; set; }

        public virtual ClassType ClassType { get; set; }

        public string Address { get; set; }

        public int CookingClassId { get; set; }

        public virtual CookingClass CookingClass { get; set; }

        // Add participants
        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }
    }
}
