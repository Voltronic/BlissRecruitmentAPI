using Newtonsoft.Json;
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
        [Key]
        [JsonIgnore]
        public int id { get; set; }

        public string choice { get; set; }

        [DefaultValue(0)]
        public int votes { get; set; }
    }

    public class ChoiceDTO
    {
        public string choice { get; set; }
    }

    public static class ChoiceUtils
    {
        public static Choice ConvertToCoice(this ChoiceDTO choice)
        {
            return new Choice { choice = choice.choice, votes = 0 };
        }

        public static ICollection<Choice> ToChoiceMap(ICollection<ChoiceDTO> choices)
        {
            return choices.Select(choice => choice.ConvertToCoice()).ToList();

        }
    }
}