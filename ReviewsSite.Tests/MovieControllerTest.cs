using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewsSite.Models;
using ReviewsSite.Controllers;
using ReviewsSite.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using Xunit;

namespace ReviewsSite.Tests
{
    public class MovieControllerTest
    {
        MovieController sut;
        Moviecontext movieContext;

        public MovieControllerTest()
        {
            movieContext = Substitute.For<Moviecontext>();
            sut = new MovieController(movieContext);
     
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            // Arrange

            // Act
            var result = sut.Index();

            // Assert
            Assert.IsType<Task<IActionResult>>(result);
        }

        
        
        [Fact]
        public void Confirm_Create_Movie_Successfully()
        {
            // Arrange
            var movie = new Movie();
        
            movie.Title = "titanic";

            var result = sut.Create(movie);

            // Act
            //  sut.Delete(movie.Id);

            // Assert
            Assert.IsType<Task<IActionResult>>(result);
            

        }




    }
}



