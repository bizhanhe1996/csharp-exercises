namespace csharp;

class Program
{
    static void Main(string[] args)
    {

        // switch exercise
        /* Exercises exercises = new Exercises();
        string result = exercises.SwitchExercise("Paris");
        Console.WriteLine(result); */

        // while exercise
        // exercises.WhileExercise(10, 100);

        // for exercises
        /* string[] names = ["Bizhan", "Sepehr", "Reza"];
        exercises.ForExercise(names); */

        // OOP Exercises
        OOPExercises oOPExercises = new();
        oOPExercises.AccessorExercise1();
        oOPExercises.AccessorExercise2();

        ArrayExercises arrayExercises = new();
        arrayExercises.PrintFirstElement();
        arrayExercises.PrintLastElement();
        arrayExercises.IterateInNames();
        arrayExercises.TwoDimensionalArrayExercise();
        arrayExercises.JaggedArrayExercise();
        arrayExercises.PrintMinOfArray();
        arrayExercises.PrintMaxOfArray();
        arrayExercises.PrintLengthOfArray();

    }


}
