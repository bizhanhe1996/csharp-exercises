namespace csharp;

class Program
{
    static void Main(string[] args)
    {
        Exercises exercises = new Exercises();
        string result = exercises.SwitchExercise("Paris");
        Console.WriteLine(result);
    }

}
