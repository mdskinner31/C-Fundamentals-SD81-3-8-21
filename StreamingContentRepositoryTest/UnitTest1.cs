using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPatterns;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            ///AAA -> Arrange, Ask, Assert

            //Arrange -> overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act -> Get/ run the code to test
            bool addResult = repository.AddContentToDirectory(content);

            //Assert -> Used to get the expected outcome of a test
            Assert.IsTrue(addResult);
        }
        //Testing the REad method
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAA Rules Apply...

            //Arrange -> initial setup

            //creating the content
            StreamingContent content = new StreamingContent();

            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();

            //Adding to the repo(content)
            repo.AddContentToDirectory(content);

            //Act
            //our plan is to store the list of steamig content w/n a variable
            List<StreamingContent> listOfMovies = repo.GetContent();

            bool directoryHasContent = listOfMovies.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);

        }

        //We will start with some private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        //This is the arrange part...

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            //we make a new movie here .... finally...
            _content = new StreamingContent("Rubber", "A care tire comes to life with the" +
                " power to make people explode",
                MaturityRating.R, GenreType.Drama, 5.8d);

            _repo.AddContentToDirectory(_content);
        }

        //retrieve content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange ....Already done above

            //Act
            StreamingContent serachResult = _repo.GetContentByTitle("Rubber");

            //Assert
            Assert.AreEqual(_content, serachResult);
        }
        //Test the Update Method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange -> Updated version of our movie
            StreamingContent newContent = new StreamingContent("Rubber Part 2", "A care tire comes to life with the" +
                 " power to make people explode",
                 MaturityRating.R, GenreType.Drama, 9.2d);

            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);
            //Console.WriteLine(GiveMeInfo(_content)
        }

        //public string GiveMeInfo(StreamingContent content)
        //{
        //
        //
        //
        //}



        //Test the Delete Method
        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);

        }
    }
}
