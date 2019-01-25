using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SharedRoleplay.Models
{
    public class Story
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        
        public string Genre { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}
