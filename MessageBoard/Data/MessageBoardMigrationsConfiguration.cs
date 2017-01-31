using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace MessageBoard.Data
{
    public class MessageBoardMigrationsConfiguration:DbMigrationsConfiguration<MessageBoardContext>
    {
        public MessageBoardMigrationsConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MessageBoardContext context)
        {
            base.Seed(context);

#if DEBUG
            if(context.Topics.Count() == 0)
            {
                var topic = new Topic()
                {
                    Title = "I like ASP.NET MVC",
                    Body = "It is making things easier.. really",
                    Created = DateTime.UtcNow,
                    Replies = new List<Reply>()
                    {
                        new Reply
                        {
                            Body = "I love it too",
                            Created = DateTime.Now
                        },
                        new Reply
                        {
                            Body = "Me too",
                            Created = DateTime.Now
                        },
                        new Reply
                        {
                            Body = "Aww sucks",
                            Created = DateTime.Now
                        }
                        
                    }

                };

                context.Topics.Add(topic);

                var anotherTopic = new Topic
                {
                    Title = "I like Ruby too",
                    Created = DateTime.Now,
                    Body = "Ruby on Rail is popular"
                };

                context.Topics.Add(anotherTopic);

                try
                {
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    var msg = ex.Message;
                }


            }
#endif
        }
    }
}