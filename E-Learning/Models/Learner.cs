using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Learning.Models
{
    public class Learner
    {
        [Key]
        private int StudID { get; set; }
        [Required]
        private string name { get; set; } 
        private string password { get; set; }
        public virtual ICollection<Subject> subject { get; set; }
    }
}