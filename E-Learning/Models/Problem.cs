using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Learning.Models
{
    public class Problem
    {
        [Key]
        public int ProblemId { get; set; }
        public string ProDesc { get; set; }
        public virtual Subject subject { get; set; }
        public virtual ICollection<Solution> solution { get; set; }
    }
}