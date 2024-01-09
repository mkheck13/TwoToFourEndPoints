namespace TwoToFourEndPoints.Services;

public class TwoQuestionsService : ITwoQuestionsService
{
    public string twoQuestions(string name, string time)
    {
        bool isTrue = int.TryParse(time, out int questTime);

        if(isTrue)
        {
            return $"That's a nice name {name}.  Seems you woke up at {questTime}.";
        }else{
            return "That's not a number, please enter one";
        }
    }
}