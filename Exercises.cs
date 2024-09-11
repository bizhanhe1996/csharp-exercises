namespace csharp;

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

    public void WhileExercise(int from, int until)
    {
        int i = from;
        while (i <= until)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    public void ForExercise(string[] names)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
    }

}