using FluentAssertions;

namespace DaFibonnaci.Domain.Tests;

public class SequencerTests
{
    private readonly Sequencer _sut;

    public SequencerTests() => _sut = new Sequencer();

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void Given0Or1WhenCalculateShouldReturnEnterdValue(int step)
    {      
        // When
        var actual = _sut.Calculate(step);

        // Should
        actual.Should().Be(step);
    }

    [Fact]
    public void GivenNegativeWhenCalculateShouldThrowArgumentOutOfRangeException()
    {
        // Given & When
        var action = () => _sut.Calculate(-5);

        // Should
        action.Should().Throw<ArgumentOutOfRangeException>();
    }

}