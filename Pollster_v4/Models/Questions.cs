﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using static Pollster_v4.Models.Enums;

namespace Pollster_v4.Models
{
    public class Questions
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string UsersName { get; set; }
        [Required]
        public string Question { get; set; }
        public QuestionType QuestionType { get; set; }
        [Required]
        public string Option1 { get; set; }
        [Required]
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
    }
}
