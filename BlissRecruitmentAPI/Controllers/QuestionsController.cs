using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BlissRecruitmentAPI.Models;

namespace BlissRecruitmentAPI.Controllers
{
    public class QuestionsController : ApiController
    {
        private QuestionChoicesContext db = new QuestionChoicesContext();

        /// <summary>
        /// Gets the list of questions
        /// </summary>
        /// <remarks>
        /// api/questions/[get]
        /// </remarks>
        /// <returns>IHttpActionResult typeof(QuestionDTO) -  Content Type Json</returns>
        // GET: api/questions
        [Route("api/questions")]
        public IQueryable<QuestionDTO> Get([FromUri] string limit = "", [FromUri] string offset = "", [FromUri] string filter = "")
        {
            IQueryable<Question> filteredQuestions;
            IQueryable<QuestionDTO> questionsDTO = null;
            int _limit;
            int _offset;

            //Filter
            if(filter != string.Empty)
            {
                //Filter by question, image_url, thumb, choice and votes
                filteredQuestions = from qt in db.Questions.Include(Choice => Choice.choices)
                           .Where(q => q.image_url.ToLower().Contains(filter) ||
                           q.question.ToLower().Contains(filter) ||
                           q.thumb_url.ToLower().Contains(filter) ||
                           q.choices.Any(c => c.choice.Contains(filter)))
                           select qt;
            }
            else
            {
                //Not filtered
                filteredQuestions = from q in db.Questions.Include(Choice => Choice.choices) select q;
            }

            //Paging
            if (int.TryParse(limit, out _limit) && int.TryParse(offset, out _offset) && _limit >= 0 && _offset >= 0)
            {
                //With limit and offset numeric and > 0
                questionsDTO = from qt in filteredQuestions.OrderBy(q => q.id).Skip(_offset).Take(_limit)
                            select new QuestionDTO()
                            {
                                id = qt.id,
                                question = qt.question,
                                image_url = qt.image_url,
                                thumb_url = qt.thumb_url,
                                published_at = qt.published_at,
                                choices = qt.choices
                            };
            }
            else if (int.TryParse(limit, out _limit) && _limit >= 0 && (!int.TryParse(offset, out _offset) || _offset < 0))
            {
                //With only limit numeric && > 0
                questionsDTO = from qt in filteredQuestions.OrderBy(q => q.id).Take(_limit)
                            select new QuestionDTO()
                            {
                                id = qt.id,
                                question = qt.question,
                                image_url = qt.image_url,
                                thumb_url = qt.thumb_url,
                                published_at = qt.published_at,
                                choices = qt.choices
                            };
            }
            else if ((!int.TryParse(limit, out _limit) || _limit < 0) && int.TryParse(offset, out _offset) && _offset >= 0)
            {
                //With only offset numeric && > 0
                questionsDTO = from qt in filteredQuestions.OrderBy(q => q.id).Skip(_offset)
                            select new QuestionDTO()
                            {
                                id = qt.id,
                                question = qt.question,
                                image_url = qt.image_url,
                                thumb_url = qt.thumb_url,
                                published_at = qt.published_at,
                                choices = qt.choices
                            };
            }
            else
            {
                //Else...
                questionsDTO = from qt in filteredQuestions.Include(Choice => Choice.choices)
                            select new QuestionDTO()
                            {
                                id = qt.id,
                                question = qt.question,
                                image_url = qt.image_url,
                                thumb_url = qt.thumb_url,
                                published_at = qt.published_at,
                                choices = qt.choices
                            };
            }

            return questionsDTO;
        }

        /// <summary>
        /// Gets a defined question
        /// </summary>
        /// <remarks>
        /// api/questions/{question_id}
        /// </remarks>
        /// <returns>IHttpActionResult typeof(QuestionDTO) -  Content Type Json</returns>
        // GET: api/questions/5
        [Route("api/questions/{question_id}", Name = "GetQuestion")]
        [ResponseType(typeof(QuestionDTO))]
        public IHttpActionResult GetQuestion(int question_id)
        {
            //Gets question from context and eager loads navigation properties
            IQueryable<QuestionDTO> questionsDTO = from qt in db.Questions.Include(Choice => Choice.choices)
                                            where qt.id == question_id
                                                   select new QuestionDTO()
                                            {
                                                id = qt.id,
                                                question = qt.question,
                                                image_url = qt.image_url,
                                                thumb_url = qt.thumb_url,
                                                published_at = qt.published_at,
                                                choices = qt.choices
                                            };

            //Checking if there is some question
            if (questionsDTO.ToList().Count == 0)
            {
                return NotFound();
            }

            return Ok(questionsDTO);
        }

        /// <summary>
        /// Adds a new question
        /// </summary>
        /// <remarks>
        /// api/questions
        /// </remarks>
        /// <returns>IHttpActionResult typeof(QuestionDTO) -  Content Type Json</returns>
        // POST: api/questions
        [HttpPost]
        [Route("api/questions")]
        [ResponseType(typeof(QuestionDTO))]
        public IHttpActionResult PostQuestion(PostQuestionDTO question)
        {
            //Validates model state
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //Map the DTO to Object
            Question questionMapped = question.ToQuestionMap();

            //Adds or updates the database
            db.Questions.AddOrUpdate(questionMapped);
            db.SaveChanges();

            //Maps the Object to DTO for response
            QuestionDTO responseQuestion = questionMapped.ConvertToQuestionDTO();

            return CreatedAtRoute("GetQuestion", new { id = responseQuestion.id }, responseQuestion);
        }

        /// <summary>
        /// Updates a new question
        /// </summary>
        /// <remarks>
        /// api/questions/{question_id}
        /// </remarks>
        /// <returns>IHttpActionResult typeof(QuestionDTO) -  Content Type Json</returns>
        // PUT: api/Questions/5
        [HttpPut]
        [Route("api/questions/{question_id}")]
        [ResponseType(typeof(QuestionDTO))]
        public IHttpActionResult PutQuestion(int question_id, QuestionDTO question)
        {
            //Map the DTO to Object
            Question _question = question.ConvertToQuestion(question_id);

            //Validates model state
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //Check if the question_id matches the DTO id
            if (question_id != question.id)
            {
                return BadRequest();
            }

            //Attaches the object to update and changes the state to modified...
            db.Questions.Attach(_question);

            var entry = db.Entry(_question);
            entry.State = EntityState.Modified;

            //including navigation properties
            foreach (var navigationProperty in _question.choices)
            {
                var entityEntry = db.Entry(navigationProperty);
                entityEntry.State = EntityState.Modified;
            }

            try
            {
                //Saves on the database
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(question_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            //Maps the Object to DTO for response
            QuestionDTO responseQuestion = _question.ConvertToQuestionDTO();

            return CreatedAtRoute("GetQuestion", new { id = responseQuestion.id }, responseQuestion);
        }

        //// DELETE: api/Questions/5
        //[ResponseType(typeof(Question))]
        //public IHttpActionResult DeleteQuestion(int id)
        //{
        //    Question question = db.Questions.Find(id);
        //    if (question == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Questions.Remove(question);
        //    db.SaveChanges();

        //    return Ok(question);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QuestionExists(int id)
        {
            return db.Questions.Count(e => e.id == id) > 0;
        }
    }
}