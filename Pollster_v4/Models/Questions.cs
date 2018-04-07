using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Pollster_v4.Models
{
    public class Questions
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Question { get; set; }
        public enum QuestionType
        {
            [EnumMember(Value = "Multiple Choice")]
            MultipleChoice = 1,
            ChooseOne = 2,
            Slider = 3
        }
    }
}
