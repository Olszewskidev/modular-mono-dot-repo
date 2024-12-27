using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMono.Modules.A.Api;
using Xunit;

namespace ModularMono.Modules.A.UnitTests;

public sealed class ModuleAControllerTests
{
    [Fact]
    public void Get_ReturnsOkResultWithExpectedMessage()
    {
        // Arrange
        var controller = new ModuleAController();

        // Act
        var result = controller.Get() as OkObjectResult;

        // Assert
        result.Should().NotBeNull();
        result!.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should().Be("Hello from Module A!");
    }
}