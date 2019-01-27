using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlissRecruitmentAPICaller.Classes
{
    public class Question
    {
        public int id { get; set; }

        public string question { get; set; }

        public string image_url { get; set; }

        public string thumb_url { get; set; }

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

    public class Choice
    {
        public int questionId { get; set; }

        public string choice { get; set; }

        public int votes { get; set; }

        public virtual Question question { get; set; }
    }

    public class ChoiceDTO
    {
        public string choice { get; set; }
    }

    public static class Extensions
    {
        public static StringContent AsJson(this object o)
         => new StringContent(JsonConvert.SerializeObject(o), Encoding.UTF8, "application/json");
    }
}
