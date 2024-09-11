namespace csharp;

class Program
{
    static void Main(string[] args)
    {

        // switch exercise
        Exercises exercises = new Exercises();
        string result = exercises.SwitchExercise("Paris");
        Console.WriteLine(result);

        // while exercise
        exercises.WhileExercise(10, 100);

        // for exercises
        string[] names = ["Bizhan", "Sepehr", "Reza"];
        exercises.ForExercise(names);

    }

}
