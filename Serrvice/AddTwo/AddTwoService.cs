using TwoToFourEndPoints.Services;

namespace TwoToFourEndPoints.Services;

public class AddTwoService : IAddTwoService
{
    public string addTwo(int x, int y)
    {
        return $"The total of {x} and {y} is {x + y}.";
    }
}