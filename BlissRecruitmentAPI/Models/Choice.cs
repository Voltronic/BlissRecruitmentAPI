using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlissRecruitmentAPI.Models
{
    public class Choice
    {
        [Key, Column(Order = 0)]
        [JsonIgnore]
        public int questionId { get; set; }

        [Key, Column(Order = 1)]
        public string choice { get; set; }

        [DefaultValue(0)]
        public int votes { get; set; }

        [JsonIgnore]
        public virtual Question question { get; set; }
    }
}