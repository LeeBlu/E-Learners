using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Learning.Models
{
    public class Mentor
    {
        public string name { get; set; }
        public string password { get; set; }
        public virtual ICollection<Subject> subject { get; set; }

    }
}