using System;
using IdeaBot.Models;

namespace IdeaBot
{
    public class Program
    {
        public static void Main()
        {
            using (var db = new IdeaContext())
            {
                var numIdeasInBatch =  Console.ReadLine();
                var ideaBatch = new IdeaBatch(Convert.ToInt32(numIdeasInBatch));
                db.IdeaBatches.Add(ideaBatch);

                for (var i = 0; i <  Convert.ToInt32(numIdeasInBatch); i++)
                {
                    db.Ideas.Add(new Idea(ideaBatch.IdeaBatchId));
                    var count = db.SaveChanges();
                    Console.WriteLine("{0} records saved to database", count);
                }

                

                // Console.WriteLine();
                // Console.WriteLine("All blogs in database:");
                // foreach (var blog in db.Blogs)
                // {
                //     Console.WriteLine(" - {0}", blog.Url);
                // }
            }
        }
    }
}