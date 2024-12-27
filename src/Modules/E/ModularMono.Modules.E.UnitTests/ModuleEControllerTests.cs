using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMono.Modules.E.Api;
using Xunit;

namespace ModularMono.Modules.E.UnitTests;

public sealed class ModuleEControllerTests
{
    [Fact]
    public void Get_ReturnsOkResultWithExpectedMessage()
    {
        // Arrange
        var controller = new ModuleEController();

        // Act
        var result = controller.Get() as OkObjectResult;

        // Assert
        result.Should().NotBeNull();
        result!.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should().Be("Hello from Module E!");
    }
}