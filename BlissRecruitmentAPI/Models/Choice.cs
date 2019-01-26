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

    public class ChoiceDTO
    {
        public string choice { get; set; }
    }

    public static class ChoiceUtils
    {
        public static Choice ConvertToChoice(this ChoiceDTO choice)
        {
            return new Choice { choice = choice.choice, votes = 0 };
        }

        public static ICollection<Choice> ToChoiceMap(ICollection<ChoiceDTO> choices)
        {
            return choices.Select(choice => choice.ConvertToChoice()).ToList();

        }

        public static Choice ConvertToUpdateChoice(this Choice choice, int id)
        {
            return new Choice { questionId = id, choice = choice.choice, votes = choice.votes };
        }

        public static ICollection<Choice> ToChoiceUpdateMap(ICollection<Choice> choices, int id)
        {
            return choices.Select(choice => choice.ConvertToUpdateChoice(id)).ToList();

        }
    }
}