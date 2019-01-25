using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlissRecruitmentAPI.Models
{
    public class Choice
    {
        //public int id { get; set; }

        [Key]
        public string choice { get; set; }

        [DefaultValue(0)]
        public int votes { get; set; }

        //public Question question { get; set; }
    }
}