using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
   public class Movie : StreamingContent
    {
        //we get all of the properties from a streaming content b/c a movie "is a " 
        public double RunTime { get; set; }

        public Movie()
        {

        }


        public Movie(string title,string description, MaturityRating maturity, GenreType genreType, double starRating,double runtime)
                    :base(title,description,MaturityRating,GenreType,starRating)
        {
            RunTime = RunTime;
        }
    }
}
