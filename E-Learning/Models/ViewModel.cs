using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Learning.Models
{
    public class ViewModel
    {
        public IEnumerable<Subject> subject { get; set; }
        public IEnumerable<Mentor> mentor { get; set; }
        public IEnumerable<Learner> learner { get; set; }
        public IEnumerable<Problem> problem { get; set; }
        public IEnumerable<Solution> solution { get; set; }

    }
}