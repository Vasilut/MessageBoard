using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageBoard.Data
{
    public class MessageBoardRepository : IMessageBoardRepository
    {
        MessageBoardContext _ctx;
        public MessageBoardRepository(MessageBoardContext ctx)
        {
            _ctx = ctx;
        }
        public IQueryable<Reply> GetRepliesByTopic(int id)
        {
            return _ctx.Replies.Where(x => x.TopicId == id);
        }

        public IQueryable<Topic> GetTopics()
        {
            return _ctx.Topics;
        }
    }
}