using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SharedRoleplay.Models
{
    public class Scene
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Setting { get; set; }

        public virtual Story Story { get; set; }

    }
}
