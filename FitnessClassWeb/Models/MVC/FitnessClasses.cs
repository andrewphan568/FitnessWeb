namespace FitnessClassWeb.Models.MVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FitnessClasses
    {
        [Key]
        public int classID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Class Title must be less than 100 characters")]
        [MinLength(2, ErrorMessage = "Class Title must be more than 2 characters")]
        [Display(Name = "Class Title")]
        public string classTitle { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Class Description must be less than 500 characters")]
        [MinLength(2, ErrorMessage = "Class Description must be more than 2 characters")]
        [Display(Name = "Class Description")]
        public string classDescription { get; set; }       

        [Display(Name = "Active")]
        public bool active { get; set; }

        [Display(Name = "Thumbnail")]
        [StringLength(500, ErrorMessage = "Thumbnail must be less than 500 characters")]        
        public string thumbnail { get; set; }

        [Display(Name = "Image")]
        [StringLength(500, ErrorMessage = "Image must be less than 500 characters")]        
        public string image { get; set; }

    }
}
