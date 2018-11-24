using System;
using System.ComponentModel.DataAnnotations; 

namespace ChildVacAPI.Models
{
    public class Child
    {

        [Key]
        public string IIN { get; set; }
        public string Name { get; set; }


        public Child()
        {
        }
    }
}
