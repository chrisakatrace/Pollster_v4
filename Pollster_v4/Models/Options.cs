using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pollster_v4.Models
{
    public class Options
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Option { get; set; }
    }
}
