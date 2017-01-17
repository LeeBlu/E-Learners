using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Learning.Models
{
    public class Solution
    {
        [Key]
        public int SolutionId { get; set; }
        public string SolutionDec { get; set; }
        public Problem problem { get; set; }
    }
}