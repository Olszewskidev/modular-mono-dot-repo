using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMono.Modules.F.Api;
using Xunit;

namespace ModularMono.Modules.F.UnitTests;

public sealed class ModuleFControllerTests
{
    [Fact]
    public void Get_ReturnsOkResultWithExpectedMessage()
    {
        // Arrange
        var controller = new ModuleFController();

        // Act
        var result = controller.Get() as OkObjectResult;

        // Assert
        result.Should().NotBeNull();
        result!.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should().Be("Hello from Module F!");
    }
}