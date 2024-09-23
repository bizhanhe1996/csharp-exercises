using System;
using System.Collections.Generic;

class ListExercises
{

    public List<int> nums = [];

    public ListExercises()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("List Exercises");
        Console.ResetColor();
    }

    public List<int> Fill()
    {
        this.nums.Add(1);
        this.nums.Add(3);
        this.nums.Add(5);
        this.nums.Add(7);
        this.nums.Add(9);
        return this.nums;
    }

    public void PrintFirstElement()
    {
        Console.WriteLine($"Le premier element de ce list est: {this.nums[0]}");
    }

    public void PrintLastElement()
    {
        Console.WriteLine($"The last element of this list is: {this.nums[this.nums.Count - 1]}");
    }

    public void PrintMinElement()
    {
        Console.WriteLine($"The minimum of this list is: {this.nums.Min()}");
    }

    public void PrintMaxElement()
    {
        Console.WriteLine($"The maximum of this list is: {this.nums.Max()}");
    }

    public void PrintSumOfElements()
    {
        Console.WriteLine($"The sum of all the elements of this list is: {this.nums.Sum()}");
    }

    public void ReverseList()
    {
        nums.Reverse();
        Console.WriteLine("The list has just been reversed.");
    }

    public void PrintLength()
    {
        Console.WriteLine($"The length of the list is: {this.nums.Count}");
    }

    public void ConvertToEvens()
    {
        this.nums = this.nums.Select(num => num = num + 1).ToList();
        Console.WriteLine("Numbers has just been converted into evens.");
    }

    public void PrintAverage()
    {
        Console.WriteLine($"The average of all the numbers in the list is: {this.nums.Average()}");
    }

}