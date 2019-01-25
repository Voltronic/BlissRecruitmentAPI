using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
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
        public IQueryable<QuestionDTO> Get([FromUri] string limit = "", [FromUri] string offset = "", [FromUri] string filter = "")
        {
            IQueryable<Question> filtered;
            IQueryable<QuestionDTO> questions = null;
            int _limit;
            int _offset;

            //Filter
            if(filter != string.Empty)
            {
                //Filter by question, image_url, thumb, choice and votes
                filtered = from b in db.Questions.Include(Choice => Choice.choices)
                           .Where(q => q.image_url.ToLower().Contains(filter) ||
                           q.question.ToLower().Contains(filter) ||
                           q.thumb_url.ToLower().Contains(filter) ||
                           q.choices.Any(r => r.choice.Contains(filter)))
                           select b;
            }
            else
            {
                //Not filtered
                filtered = from b in db.Questions.Include(Choice => Choice.choices) select b;
            }

            //Paging
            if (int.TryParse(limit, out _limit) && int.TryParse(offset, out _offset) && _limit >= 0 && _offset >= 0)
            {
                //With limit and offset numeric and > 0
                questions = from b in filtered.OrderBy(q => q.id).Skip(_offset).Take(_limit)
                            select new QuestionDTO()
                            {
                                id = b.id,
                                question = b.question,
                                image_url = b.image_url,
                                thumb_url = b.thumb_url,
                                published_at = b.published_at,
                                choices = b.choices
                            };
            }
            else if (int.TryParse(limit, out _limit) && _limit >= 0 && (!int.TryParse(offset, out _offset) || _offset < 0))
            {
                //With only limit numeric && > 0
                questions = from b in filtered.OrderBy(q => q.id).Take(_limit)
                            select new QuestionDTO()
                            {
                                id = b.id,
                                question = b.question,
                                image_url = b.image_url,
                                thumb_url = b.thumb_url,
                                published_at = b.published_at,
                                choices = b.choices
                            };
            }
            else if ((!int.TryParse(limit, out _limit) || _limit < 0) && int.TryParse(offset, out _offset) && _offset >= 0)
            {
                //With only offset numeric && > 0
                questions = from b in filtered.OrderBy(q => q.id).Skip(_offset)
                            select new QuestionDTO()
                            {
                                id = b.id,
                                question = b.question,
                                image_url = b.image_url,
                                thumb_url = b.thumb_url,
                                published_at = b.published_at,
                                choices = b.choices
                            };
            }
            else
            {
                //Else...
                questions = from b in filtered.Include(Choice => Choice.choices)
                            select new QuestionDTO()
                            {
                                id = b.id,
                                question = b.question,
                                image_url = b.image_url,
                                thumb_url = b.thumb_url,
                                published_at = b.published_at,
                                choices = b.choices
                            };
            }

            return questions;
        }


        // GET: api/questions/5
        [Route("api/questions/{id}")]
        [ResponseType(typeof(QuestionDTO))]
        public IHttpActionResult GetQuestion(int id)
        {
            IQueryable<QuestionDTO> question = from b in db.Questions.Include(Choice => Choice.choices)
                                            where b.id == id
                                            select new QuestionDTO()
                                            {
                                                id = b.id,
                                                question = b.question,
                                                image_url = b.image_url,
                                                thumb_url = b.thumb_url,
                                                published_at = b.published_at,
                                                choices = b.choices
                                            };

            if (question.ToList().Count == 0)
            {
                return NotFound();
            }

            return Ok(question);
        }

        // PUT: api/Questions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutQuestion(int id, Question question)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != question.id)
            {
                return BadRequest();
            }

            db.Entry(question).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Questions
        [ResponseType(typeof(Question))]
        public IHttpActionResult PostQuestion(Question question)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Questions.Add(question);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = question.id }, question);
        }

        // DELETE: api/Questions/5
        [ResponseType(typeof(Question))]
        public IHttpActionResult DeleteQuestion(int id)
        {
            Question question = db.Questions.Find(id);
            if (question == null)
            {
                return NotFound();
            }

            db.Questions.Remove(question);
            db.SaveChanges();

            return Ok(question);
        }

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