using FluentAssertions;

namespace DaFibonnaci.Domain.Tests;

public class SequencerTests
{
    private readonly Sequencer _sut;

    public SequencerTests() => _sut = new Sequencer();

    [Fact]
    public void GivenNegativeWhenCalculateShouldThrowArgumentOutOfRangeException()
    {
        // Given & When
        var action = () => _sut.Calculate(-5);

        // Should
        action.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Theory]
    [MemberData(nameof(FibonnaciData))]
    public void GivenStepWhenCalculateShouldReturnExpected(int step, int expected)
    {
        // Given & When
        var actual = _sut.Calculate(step);

        // Should
        actual.Should().Be(expected);
    }

    public static TheoryData<int, int> FibonnaciData() 
        => new()
        {
            { 0, 0 },
            { 1, 1 },
            { 2, 1 },
            { 3, 2 },
            { 4, 3 },
            { 5, 5 },
            { 6, 8 },
            { 7, 13 },
            { 8, 21 },
            { 9, 34 },
            { 10, 55 }
        };
}