
namespace DaFibonnaci.Domain;

public class Sequencer
{
    /// <summary>
    /// Calculate the nth term of the fibonnaci sequence
    /// </summary>
    /// <param name="step"> the nth term which we want the value of</param>
    /// <returns>the value of the fibonnaci sequence calcluated at the nth term</returns>
    public int Calculate(int step)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(step);
        if (step == 0 || step == 1) return step;
        return Calculate(step - 1) + Calculate(step - 2);
    } 
}
