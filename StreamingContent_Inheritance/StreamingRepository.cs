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
        //We will use the same _contentDirectory for StreamingcontentRepository
        //Read -> show
        public Show GetShowByTitle(string title)
        {
            //To find a specific show
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
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
            //use this to add our shows ->starts empty (we will return this list)
            List<Show> allShows = new List<Show>();

            foreach (StreamingContent content in _contentDirectory)
            {
               if (content is Show)
               {
                    //add the show to the allShows list
                    allShows.Add((Show)content);
               }
            }

            return allShows;
        }

        //Read get all moview
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach (StreamingContent content in _contentDirectory)
            {

                if (content is Movie)
                {
                    allMovies.Add(content as Movie);
                }

            }
            return allMovies;
        }

       

       // public List<Show> GetShowsByEpisodeCount(int EpisodeCountNumber)
      // {
       //    List<Show> allShows = new List<Show>();
       //    foreach (Show content in _contentDirectory)
       //    {
      //          if (EpisodeCountNumber > 7)
      //          {
                    
          //      }
               
         //   }
               
       //}

    }
}
