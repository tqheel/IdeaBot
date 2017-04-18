using System;
using System.Collections.Generic;

namespace IdeaBot.Models
{
    public class IdeaBatch
    {
        public int IdeaBatchId { get; set; }
        public long IdeaTime { get; set; }
        public long IdeaBatchTime { get; set; }  
        
        public List<Idea> Ideas { get; set; }   
        public IdeaBatch ()
        {
            var now = DateTime.Now;
            var dto = new DateTimeOffset(now);
            this.IdeaBatchTime = dto.ToUnixTimeSeconds();
        }
    }
}