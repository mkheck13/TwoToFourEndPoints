namespace TwoToFourEndPoints.Services;

public class TwoQuestionsService : ITwoQuestionsService
{
    public string twoQuestions(string name, int time)
    {
        // bool isTrue = int.TryParse(time, out int questTime);

        if(time <= 12)
        {
            return $"That's a nice name {name}.  Seems you woke up at {time}.";
        }else {
            return "That's not a vaild number, please enter one that is between 1 to 12";
        }
    }
}