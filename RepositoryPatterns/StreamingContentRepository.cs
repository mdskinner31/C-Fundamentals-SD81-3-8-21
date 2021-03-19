using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterns
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = _contentDirectory.Count > startingCount;
            return wasAdded;

        }

        //Read
        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }

        //Helper method
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }

            return null;
        }


        public StreamingContent GetContentByDescription(string description)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Description.ToLower() == description.ToLower())
                {
                    return content;
                }
            }

            return null;
        }


        public StreamingContent GetContentByGenreType(GenreType genretype)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GenreType == genretype)
                {
                    return content;
                }
            }

            return null;
        }






        //Update

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            // Find the content
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            //Updaet the content
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;

                return true;

            }  
            else
            {
                return false;
            }
        } 

        //Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}



