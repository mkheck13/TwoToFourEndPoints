namespace TwoToFourEndPoints.Services;

public class GreaterService : IGreaterService
{
    public string compare(int x, int y)
    {
        if (x > y)
        {
            return $"It appears that {x} is greater than {y}.\nIt appears that {y} is less than {x}.";

        }else if(x == y)
        {
            return $"It appears that {x} and {y} are equal.";
        }else
        {
            return $"It appears that {y} is greater than {x}.\nIt appears that {x} is less then {y}.";
        }
    }
}