using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharedRoleplay.Models
{
    public class Story
    {
        //public Story()
        //{
        //    this.Characters = new List<Character>();
        //}

        public int ID { get; set; }
        public string Title { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated { get; set; }

        public string Genre { get; set; }

        //public int CharacterId { get; set; }
        //[ForeignKey("CharacterId")]
        //public Character Character { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Scene> Scenes { get; set; }
    }
}
