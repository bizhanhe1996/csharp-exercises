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

    ~ArrayExercises()
    {
        Console.WriteLine("Finished Array Exercises.");
    }

}