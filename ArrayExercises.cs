namespace csharp;

using System;

class ArrayExercises
{

    public string[] names;

    public ArrayExercises()
    {
        Console.WriteLine("Array Exercises:");
        this.names = ["Bizhan", "Sina", "Benyamin", "Siavash", "Reza"];
    }

    public void PrintFirstElement()
    {
        Console.WriteLine($"The first element is: {this.names[0]}");
    }

    public void PrintLastElement()
    {
        Console.WriteLine($"The last element is: {this.names[this.names.Length - 1]}");
    }

    public void IterateInNames()
    {
        string total = "";
        foreach (string name in names)
        {
            total += name + ", ";
        }
        Console.WriteLine($"All names: {total}");
    }

    public void TwoDimensionalArrayExercise()
    {
        string[,] names = new string[2, 3] {
            {"Bizhan","Behrad","Sepehr"},
            {"Hejazi","Iranzad","Khorasani"}
        };
        Console.WriteLine($"Full name is {names[0, 0]} {names[1, 0]}");
    }

    public void JaggedArrayExercise()
    {
        // Jagged arrays are different that multidimensional arrays
        string[][] cities = [
            ["Iran","Greece","France","China","Italy","Turkey"],
            ["Tehran","Athens","Paris"],
            ["Asia","Europe"]
        ];
        Console.WriteLine($"The capital of {cities[0][0]} is {cities[1][0]} which is located in {cities[2][0]}.");
    }

    public void PrintMinOfArray()
    {
        int[] ages = [12, 54, 32, 65, 12, 9, 12, 7];
        Console.WriteLine($"The minimum of the array is: {ages.Min()}");
    }

    public void PrintMaxOfArray()
    {
        double[] doubles = [3.14d, 2.17d, 7d, 15.6d];
        Console.WriteLine($"The maximum value inside the array is {doubles.Max()}.");
    }

    public void PrintLengthOfArray()
    {
        decimal[] decimals = [23.23m, 43.12m, 652.5412m, 1909.943m];
        Console.WriteLine($"The length of array is: {decimals.Length}.");
    }

    ~ArrayExercises()
    {
        Console.WriteLine("Finished Array Exercises.");
    }

}