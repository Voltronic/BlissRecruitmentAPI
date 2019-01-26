using BlissRecruitmentAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlissRecruitmentAPI.DTO
{
    //Choice
    public class ChoiceDTO
    {
        public string choice { get; set; }
    }

    //Question
    public class QuestionDTO
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string question { get; set; }

        [Required]
        public string image_url { get; set; }

        [Required]
        public string thumb_url { get; set; }

        [Required]
        public DateTime published_at { get; set; }

        [Required]
        public ICollection<Choice> choices { get; set; }
    }

    public class PostQuestionDTO
    {
        [Required]
        public string question { get; set; }

        [Required]
        public string image_url { get; set; }

        [Required]
        public string thumb_url { get; set; }

        [Required]
        public DateTime published_at { get; set; }

        [Required]
        public ICollection<ChoiceDTO> choices { get; set; }
    }

    //Result
    public class ResultDTO
    {
        public string status { get; set; }
    }
}