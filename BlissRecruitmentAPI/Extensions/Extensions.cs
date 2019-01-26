using BlissRecruitmentAPI.DTO;
using BlissRecruitmentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlissRecruitmentAPI.Extensions
{
    //Choice
    public static class ChoiceExtensions
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

    //Question
    public static class QuestionExtensions
    {
        public static Question ToQuestionMap(this PostQuestionDTO question)
        {
            return new Question()
            {
                question = question.question,
                image_url = question.image_url,
                thumb_url = question.thumb_url,
                published_at = question.published_at,
                choices = ChoiceExtensions.ToChoiceMap(question.choices)
            };
        }

        public static QuestionDTO ConvertToQuestionDTO(this Question question)
        {
            return new QuestionDTO
            {
                id = question.id,
                question = question.question,
                image_url = question.image_url,
                thumb_url = question.thumb_url,
                published_at = question.published_at,
                choices = question.choices
            };
        }

        public static Question ConvertToQuestion(this QuestionDTO question, int id)
        {
            return new Question
            {
                id = question.id,
                question = question.question,
                image_url = question.image_url,
                thumb_url = question.thumb_url,
                published_at = question.published_at,
                choices = ChoiceExtensions.ToChoiceUpdateMap(question.choices, id)
            };
        }
    }
}