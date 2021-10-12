using System;
using Xunit;
using ReviewsSite.Models;

namespace ReviewsSite.Tests
{
    public class MovieTest
    {
        public Movie movie1 = new Movie();
        [Fact]
        public void Movie_Title_Confirmation_Test()
        {
            movie1.Title = "Fight Club";

            Assert.Equal("Fight Club", movie1.Title);

        }

        [Fact]
        public void Movie_Id_Test()
        {
            movie1.Id = 1;
            Assert.Equal(1, movie1.Id);

        }





    }
}
/*public int Id { get; set; }
public string Title { get; set; }
public string Rating { get; set; }
public string Genre { get; set; }
public int ReleaseYear { get; set; }
public string Award { get; set; }*/
