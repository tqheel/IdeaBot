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
                Console.WriteLine("How many crazy ideas would you like me to store?: ");
                //FIXME: error trap this to ensure number entered
                var numIdeasInBatch =  Console.ReadLine();
                var ideaBatch = new IdeaBatch();
                db.IdeaBatches.Add(ideaBatch);
                for (var i = 0; i <  Convert.ToInt32(numIdeasInBatch); i++)
                {
                    Console.WriteLine($"Tell me crazy idea number {i + 1}:");
                    var idea = new Idea(ideaBatch.IdeaBatchId);
                    idea.IdeaText = Console.ReadLine();
                    db.Ideas.Add(idea);
                    db.SaveChanges();
                    Console.WriteLine("That is an awesome idea and it has been saved by IdeaBot. Well done.");
                }
                Console.WriteLine($"Your work is done. {Convert.ToInt32(numIdeasInBatch)} ideas packed away. Now go do some actual work, you dilettante!");


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