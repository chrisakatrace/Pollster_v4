using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Pollster_v4.Models
{
    public class Enums
    {
        public enum Gender
        {
            Male = 0,
            Female = 1, 
            Intersex = 2
        }

        public enum Education
        {
            [EnumMember(Value = "Some High School")]
            SomeHighSchool = 0,
            [EnumMember(Value = "High School Diploma or GED")]
            HighSchool = 1,
            [EnumMember(Value = "Associate's or 2 Year Degree")]
            Associates = 2,
            [EnumMember(Value = "Bachelor's or 4 Year Degree")]
            Bachelors = 3,
            [EnumMember(Value = "Master's Degree")]
            Masters = 4,
            [EnumMember(Value = "Graduate's Degree")]
            Doctorates = 5
        }

        public enum Income
        {
            [EnumMember(Value = "Less than $15,000")]
            Less15K = 0,
            [EnumMember(Value = "$15,001 to $50,0000")]
            Less50K = 1,
            [EnumMember(Value = "$50,001 to $100,000")]
            Less100K = 3,
            [EnumMember(Value = "$100,001 to $150,000")]
            Less150K = 4,
            [EnumMember(Value = "$150,001 to $250,000")]
            Less250K = 5,
            [EnumMember(Value = "$250,001 to $400,000")]
            Less400K = 6,
            [EnumMember(Value = "Greater than $400,000")]
            Over400K = 7
        }

        public enum MaritalStatus
        {
            Single = 0,
            Married = 1,
            Committed = 3
        }

        public enum Religion
        {
            [EnumMember(Value = "Atheist (No Belief)")]
            Atheist = 0,
            [EnumMember(Value = "Agnostic (Don't Care)")]
            Agnostic = 1,
            Catholic = 2,
            Muslim = 3,
            Hindu = 4,
            Jewish = 5,
            Budhist = 6,
            Christain = 7
        }

        public enum Politics
        {
            Progressive = 0,
            Democrat = 1,
            Moderate = 2,
            Republican = 3,
            Regressive = 4
        }
    }
}
