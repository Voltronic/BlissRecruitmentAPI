namespace BlissRecruitmentAPI.Migrations
{
    using BlissRecruitmentAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlissRecruitmentAPI.Models.QuestionChoicesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BlissRecruitmentAPI.Models.QuestionChoicesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Questions.AddOrUpdate(new Question()
            {
                question = "Favourite programming language?",
                image_url = "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)",
                thumb_url = "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)",
                published_at = DateTime.Now,
                choices = new List<Choice>
                {
                    new Choice() { choice = "Swift", votes = 0 },
                    new Choice() { choice = "Python", votes = 0 },
                    new Choice() { choice = "Objective-C", votes = 0 },
                    new Choice() { choice = "Ruby", votes = 0 }
                }
            });

            context.Questions.AddOrUpdate(new Question()
            {
                question = "What is your favourite song?",
                image_url = "https://dummyimage.com/600x400/000/fff.png&text=question+1+image+(600x400)",
                thumb_url = "https://dummyimage.com/120x120/000/fff.png&text=question+1+image+(120x120)",
                published_at = DateTime.Now,
                choices = new List<Choice>
                {
                    new Choice() { choice = "Uooou", votes = 0 },
                    new Choice() { choice = "Nice!", votes = 0 },
                    new Choice() { choice = "Yep", votes = 0 },
                    new Choice() { choice = "Anywhere", votes = 0 }
                }
            });
        }
    }
}
