using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoFixture;
using Blazored.Modal.Services;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Bunit;
using Bunit.Rendering;
using FluentAssertions;
using blazor.Client.Models;
using blazor.Client.Pages;
using blazor.Client.Pages.Admin.UserManagement;
using blazor.Client.Pages.Utils;
using blazor.Client.Services.EntityServices.User;
using blazor.Client.Test.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace blazor.Client.Test.Pages.Admin.UserManagement
{
    public class UserDetailTest : TestContext
    {
        private readonly Mock<IUserService> _userService;
        private readonly Mock<INavigationService> _navidationService;
        private readonly AutoFixture.Fixture _fixture = new AutoFixture.Fixture();

        public UserDetailTest()
        {
            _userService = new Mock<IUserService>();
            _navidationService = new Mock<INavigationService>();
            Services.AddBlazorise(options =>
                {
                    options.ChangeTextOnKeyPress = true;
                })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();
            Services.AddSingleton<IUserService>(_userService.Object);
            Services.AddSingleton<INavigationService>(_navidationService.Object);
        }


        [Fact]
        public void Should_DisplayUserLogin_When_IdIsPresent()
        {
            //Arrange
            var user = _fixture.Create<UserModel>();
            _userService.Setup(service => service.Get(It.IsAny<string>())).Returns(Task.FromResult(user));
            var userDetail = RenderComponent<UserDetail>(ComponentParameter.CreateParameter("Id", "test"));
            

            // Act
            var title = userDetail.Find("h2");

            // Assert
            title.MarkupMatches($"<h2><span>User</span> [<b>{user.Login}</b>]</h2>");

        }

        [Fact]
        public void Should_NotDisplayUser_When_IdIsNotPresent()
        {
            //Arrange
            _userService.Setup(service => service.Get(It.IsAny<string>())).Returns(Task.FromResult(new UserModel()));
            var userDetail = RenderComponent<UserDetail>();
            
            // Act
            var title = userDetail.Find("div.col-8");

            // Assert
            title.Children.Length.Should().Be(0);

        }
    }
}
