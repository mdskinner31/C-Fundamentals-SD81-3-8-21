using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
   public class StreamingRepository : StreamingContentRepository
    {
        //We will use the same _contentDirectory for StreamingdontentRepository
        //Read -> show
        public Show GetShowByTitle(string title)
        {
            //To find a specific show
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }

            }
            return null;
        }
        //Read -> Movie
        public Movie GetMoveByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }   

        //Read get all
        public List<Show> GetAllShows()
        {

        }

    }
}
