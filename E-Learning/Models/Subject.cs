using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Learning.Models
{
    public class Subject
    {
        [Key]
        private int SubjectId { get; set; }
        public string SubjectName { get; set; }
        private string Marks { get; set; }
        public virtual Mentor mentor { get; set; }
        public virtual ICollection<Problem> problem { get; set; }

    }
}