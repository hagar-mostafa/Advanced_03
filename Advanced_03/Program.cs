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

        Console.WriteLine("\n\n ====================== Exercise 2: Leaderboard ======================\n");
        #region Exercise 2: Leaderboard
        SortedDictionary< int , string > Leaderboard = new SortedDictionary< int , string >()
        {
            {500 , "Ahmed" } ,
            { 200 , "Sara" } ,
            { 800 , "Ali" } ,
            { 350 , "Mona" }
        };
        foreach (var item in Leaderboard)
            Console.WriteLine ($" {item.Key}  , {item.Value}");

        Console.WriteLine("\n ========================================================");

        Console.WriteLine($"The first key is {Leaderboard.Keys.First()} , and it's value is {Leaderboard.Values.First()}");

        Console.WriteLine("\n ========================================================");

        bool exists = Leaderboard.ContainsKey(500);
        Console.WriteLine($" Check if score 500 exists : {exists}");

        Console.WriteLine("\n ========================================================");

        if (Leaderboard.TryGetValue(900, out string val))
            Console.WriteLine(val);
        else
            Console.WriteLine("The key Not found");

        Console.WriteLine("\n ========================================================");

        Leaderboard.Remove(200);
        foreach (var item in Leaderboard)
            Console.WriteLine($" {item.Key}  , {item.Value}");
        #endregion

        Console.WriteLine("\n\n ====================== Exercise 3: Phone Book ======================\n");

        #region Exercise 3: Phone Book
        var phoneBook = new Dictionary<string, string>
        {
            { "Ahmed", "01012345678" },
            { "Sara",  "01123456789" },
            { "Omar",  "01234567890" },
            { "Mona",  "01500000000" }
        };

      
        phoneBook["Youssef"] = "01099999999";
        phoneBook["Sara"] = "01100000000";

        try
        {
            phoneBook.Add("Ahmed", "01111111111");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        bool added = phoneBook.TryAdd("Ahmed", "01111111111");
        Console.WriteLine($"TryAdd succeeded? {added}");

        if (phoneBook.TryGetValue("Khaled", out string number))
            Console.WriteLine($"Khaled: {number}");
        else
            Console.WriteLine("Khaled was not found.");

        string result = phoneBook.GetValueOrDefault("Khaled", "Not Found");
        Console.WriteLine($"Khaled: {result}");

        Console.WriteLine(string.Join(", ", phoneBook.Keys));
        Console.WriteLine(string.Join(", ", phoneBook.Values));
   


        #endregion
    }


}