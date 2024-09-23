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
        // OOPExercises oOPExercises = new();
        // oOPExercises.AccessorExercise1();
        // oOPExercises.AccessorExercise2();

        // Les Exercises du Arrays
        // ArrayExercises arrayExercises = new();
        // arrayExercises.PrintFirstElement();
        // arrayExercises.PrintLastElement();
        // arrayExercises.IterateInNames();
        // arrayExercises.TwoDimensionalArrayExercise();
        // arrayExercises.JaggedArrayExercise();
        // arrayExercises.PrintMinOfArray();
        // arrayExercises.PrintMaxOfArray();
        // arrayExercises.PrintLengthOfArray();

        // List exercises
        ListExercises listExercises = new();
        listExercises.Fill();
        listExercises.PrintFirstElement();
        listExercises.PrintLastElement();
        listExercises.PrintMinElement();
        listExercises.PrintMaxElement();
        listExercises.ReverseList();
        listExercises.PrintFirstElement();
        listExercises.PrintLength();
        listExercises.ConvertToEvens();
        listExercises.PrintFirstElement();
        listExercises.PrintAverage();

    }


}
