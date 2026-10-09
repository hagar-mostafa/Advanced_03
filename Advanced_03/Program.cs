using System;
using System.Net;
#nullable disable

public class Program
{
    public static void Main(string [] args)
    {
        Console.WriteLine(" ======================Exercise 1: Student Grade Manager======================");
        #region Exercise 1: Student Grade Manager
        // List is a generic collection
        List<int> Grade = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };
        Console.WriteLine ("\nThis collection contain the follwoing\n ");
        foreach (var item in Grade)
            Console.Write(item + " ");
        Console.WriteLine("\n ========================================================");

        Console.WriteLine($"This collection has {Grade.Count} elements ");
        Console.WriteLine("\n ========================================================");

        Console.WriteLine($"The first element is  {Grade[0]} , The last element is {Grade[Grade.Count - 1 ]} ");
        Console.WriteLine("\n ========================================================");

        Grade.Sort(); // automatic in ascending order
        Console.WriteLine("The list after sorting is ");

        foreach (var item in Grade)
            Console.Write(item + " ");
        Console.WriteLine("\n ========================================================");

        Console.WriteLine($"The first element above 90 grade is {Grade.Find(x => x > 90)} ");

        Console.WriteLine("\n ========================================================");

        var fail = Grade.FindAll(x => x < 75);
        Console.WriteLine($"The failing grades is ");
        foreach (var item in fail)
            Console.Write(item + " ");
        Console.WriteLine("\n ========================================================");


        foreach (var item in fail)
            Grade.Remove(item);
        Console.WriteLine("The list after removing failing elements ");

        foreach (var item in Grade)
            Console.Write(item + " ");

        Console.WriteLine("\n ========================================================");

        bool check = Grade.Contains( 100);

        Console.WriteLine($"Check if any grade equals {check} ");

        Console.WriteLine("\n ========================================================");

        List<string> grade = new List<string>();
        foreach (var item in Grade)
        {
            string i = Convert.ToString(item);
            grade.Add (i);
        }

        Console.WriteLine("The list after coverting into ");
        foreach (var item in grade)
            Console.Write($"Grade : {item}   ");


        #endregion
    }


}