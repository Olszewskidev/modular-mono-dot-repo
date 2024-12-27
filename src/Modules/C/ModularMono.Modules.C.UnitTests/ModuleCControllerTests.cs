using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModularMono.Modules.C.Api;
using Xunit;

namespace ModularMono.Modules.C.UnitTests;

public sealed class ModuleCControllerTests
{
    [Fact]
    public void Get_ReturnsOkResultWithExpectedMessage()
    {
        // Arrange
        var controller = new ModuleCController();

        // Act
        var result = controller.Get() as OkObjectResult;

        // Assert
        result.Should().NotBeNull();
        result!.StatusCode.Should().Be(StatusCodes.Status200OK);
        result.Value.Should().Be("Hello from Module C!");
    }
}