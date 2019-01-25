using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlissRecruitmentAPI.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string question { get; set; }

        public string image_url { get; set; }

        public string thumb_url { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm:ss.fff}")]
        public DateTime published_at { get; set; }

        public ICollection<Choice> choices { get; set; }
    }

    public class QuestionDTO
    {
        public int id { get; set; }

        public string question { get; set; }

        public string image_url { get; set; }

        public string thumb_url { get; set; }

        public DateTime published_at { get; set; }

        public ICollection<Choice> choices { get; set; }
    }

    public class PostQuestionDTO
    {
        public string question { get; set; }

        public string image_url { get; set; }

        public string thumb_url { get; set; }

        public DateTime published_at { get; set; }

        public ICollection<ChoiceDTO> choices { get; set; }
    }

    public static class QuestionUtils
    {
        public static Question ToQuestionMap(this PostQuestionDTO question)
        {
            return new Question()
            {
                question = question.question,
                image_url = question.image_url,
                thumb_url = question.thumb_url,
                published_at = question.published_at,
                choices = ChoiceUtils.ToChoiceMap(question.choices)
            };
        }

        public static QuestionDTO ConvertToQuestionDTO(this Question question)
        {
            return new QuestionDTO {
                id = question.id,
                question = question.question,
                image_url = question.image_url,
                thumb_url = question.thumb_url,
                published_at = question.published_at,
                choices = question.choices
            };
        }
    }
}