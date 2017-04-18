using System;

namespace IdeaBot.Models
{
    public class Idea
    {
        public int IdeaId { get; set; }        
        public long IdeaTime { get; set; }
        public string IdeaText { get; set; }

        public int IdeaBatchId { get; set; }
        public IdeaBatch IdeaBatch { get; set; }       

        public Idea (int ideaBatchId)
        {
            this.IdeaBatchId = ideaBatchId;
            var now = DateTime.Now;
            var dto = new DateTimeOffset(now);
            this.IdeaTime = dto.ToUnixTimeMilliseconds();
        }
    }
}