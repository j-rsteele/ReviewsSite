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

/*
 * 
 *   private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }
 * 
 * 
 * 
 * 
 * public class CourseControllerTests
{
    CourseController sut;
    IRepository<Course> courseRepo;

    public CourseControllerTests()
    {
        courseRepo = Substitute.For<IRepository<Course>>();
        sut = new CourseController(courseRepo);
    }

    [Fact]
    public void Index_Returns_A_View()
    {
        // Arrange

        // Act
        var result = sut.Index();

        // Assert
        Assert.IsType<ViewResult>(result);
    }

    [Fact]
    public void Delete_Displays_Course_To_Delete_Successfully()
    {
        // Arrange
        var course = new Course(1, "Test Course");

        // Act
        var result = sut.DeleteCourse(course.Id);

        // Assert
        //Assert.Equal(course, result.Model);
        Assert.IsType<RedirectToActionResult>(result);

    }
}*/


