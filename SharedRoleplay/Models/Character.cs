using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SharedRoleplay.Models
{
    public class Character
    {

        public int ID { get; set; }

        // Collection of information to define a Character.
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string SexualOrientation { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string EyeColor { get; set; }
        public string HeirColor { get; set; }
        public string Race { get; set; }
        public string Species { get; set; }
        public string Languages { get; set; }
        public string BackStory { get; set; }
        public string Miscellaneous { get; set; }

        // Foreign Key linking Characters to Scenes

        //public virtual ICollection<Scene> Scene { get; set; }

        

    }
}
