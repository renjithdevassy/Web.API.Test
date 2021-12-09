using Books.Core.Domain.Books;
using Books.Web.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Books.Web.API.Test
{
    public class BooksControllerTest
    {
        private readonly BooksController _controller;
        [Fact]
        public void Get_Books()
        {
            // Act
            var okResult = _controller.GetBooks();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);

        }
    }
}