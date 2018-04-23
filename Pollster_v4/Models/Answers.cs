using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pollster_v4.Models
{
    public class Answers
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public int QuestionId { get; set; }
        [Required]
        public int OptionNumber { get; set; }
    }
}
