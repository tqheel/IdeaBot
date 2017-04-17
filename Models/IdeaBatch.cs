using System;
using System.Collections.Generic;

namespace IdeaBot.Models
{
    public class IdeaBatch
    {
        public int IdeaBatchId { get; set; }
        public long IdeaTime { get; set; }
        public string IdeaText { get; set; }   
        public long IdeaBatchTime { get; set; }
        public int  NumIdeasInBatch { get; set; }     
        
        public List<Idea> Ideas { get; set; }   
        public IdeaBatch (int numIdeasInBatch)
        {
            this.IdeaBatchTime = Convert.ToInt64(DateTime.Now);
            this.NumIdeasInBatch = numIdeasInBatch;
        }
    }
}