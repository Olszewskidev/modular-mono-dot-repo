using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMono.Modules.I.Api;
using Xunit;

namespace ModularMono.Modules.I.UnitTests;

public sealed class ModuleIControllerTests
{
    [Fact]
    public void Get_ReturnsOkResultWithExpectedMessage()
    {
        // Arrange
        var controller = new ModuleIController();

        // Act
        var result = controller.Get() as OkObjectResult;

        // Assert
        result.Should().NotBeNull();
        result!.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should().Be("Hello from Module I!");
    }
}