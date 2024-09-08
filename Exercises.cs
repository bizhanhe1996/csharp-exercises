public class Exercises
{

    public string SwitchExercise(string capital)
    {
        switch (capital.ToLower())
        {
            case "paris":
                return "France";
            case "berlin":
                return "Germany";
            case "rome":
                return "Italy";
            case "london":
                return "United Kingdom";
            default:
                return "unknown";
        }
    }

}