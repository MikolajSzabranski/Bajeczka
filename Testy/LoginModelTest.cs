using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using System;
using System.Linq.Expressions;

namespace Bajeczkav2.Tests
{
    public class LoginModelTests
    {
        [Fact]
        public async Task OnPostAsync_ValidUser_RedirectToIndex()
        {
            // Arrange
            var dbContextMock = new Mock<ApplicationDbContext>();
            dbContextMock.Setup(d => d.Users.FirstOrDefaultAsync(It.IsAny<Expression<Func<UserEntity, bool>>>(), default))
                .ReturnsAsync(new UserEntity { Id = 1, Login = "1", Password = "1" });

            var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, "1") }));

            var loginModel = new LoginModel(dbContextMock.Object)
            {
                Username = "1",
                Password = "1"
            };

            // Act
            var result = await loginModel.OnPostAsync();

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var redirectToPageResult = (RedirectToPageResult)result;
            Assert.Equal("/Index", redirectToPageResult.PageName);
        }
    }
}