using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedRoleplay.Models
{
    public class Story
    {

        public int ID { get; set; }

        [Required]
        [Display(Name ="Story Title")]
        [StringLength(250, ErrorMessage = "Name is limited to 250 characters in length.", MinimumLength = 3)]
        public string Title { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[Display(Name ="Date Created")]
        //public DateTime DateCreated { get; set; }

        [Display(Name ="Story Genre")]
        public string Genre { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Scene> Scenes { get; set; }
    }
}
