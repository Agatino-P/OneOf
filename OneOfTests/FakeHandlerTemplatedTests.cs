using FluentAssertions;
using OneOfSut;
using System.Threading.Tasks;

namespace OneOfTests;

public class FakeHandlerTemplatedTests
{
    private readonly FakeHandlerTemplated sut = new();

    [Fact]
    public async Task ShouldSuccessOnEven()
    {
        (await sut.Handle(4)).Should().Be("Success");
    }

    [Fact]
    public async Task ShouldFailOnOdd()
    {
        (await sut.Handle(7)).Should().Be("Number is not Even");
    }
}
