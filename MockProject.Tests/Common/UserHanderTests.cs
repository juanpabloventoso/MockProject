using MockProject.Data;
using MockProject.Model;
using MockProject.Tests;
using MockProject.Tests.Helpers;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using Xunit;

namespace MockProject.Tests.Common
{

    public class UserHandlerTests
    {

        // Should return a user with ID 1
        [Fact]
        public async void GetUserIDByEmailTest()
        {
            // Create a mock version of the DbContext
            var DbContext = new Mock<IMockProjectDbContext>();

            // Users getter will return our mock DbSet with test data
            // (Here is where we call our helper function)
            DbContext.SetupGet(x => x.Users).Returns(TestFunctions.GetDbSet<User>(TestData.Users).Object);

            // Call the function to test
            var UserHandler = new MockProject.Common.UserHandler(DbContext.Object);
            var Result = await UserHandler.GetUserIDByEmail("admin@host.com");

            // Verify the results
            Assert.Equal(1, Result);
        }

    }

}
