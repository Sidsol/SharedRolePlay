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
        public string Title { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[Display(Name ="Date Created")]
        //public DateTime DateCreated { get; set; }

        [Display(Name ="Story Genre")]
        public string Genre { get; set; }

        public virtual ICollection<Scene> Scenes { get; set; }
    }
}
