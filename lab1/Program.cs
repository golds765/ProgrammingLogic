using System.Text.Encodings.Web;

namespace lab1;

class Program
{
    static void Main(string[] args)
    {
        /*
        Name: Goldie Quibol
        Title: IT-1050 - Lab 1
        */

        //Step 2
        Console.WriteLine("Goldie Quibol");
        Console.WriteLine("IT-1050 - Lab 1");

        //Step 3
        int favoriteNumber = 7;
        string favoriteLanguage = "Java";
        double programsWritten = 5.5;
        bool haveExperience = true;

        Console.WriteLine("My favorite number is" + favoriteNumber);
        Console.WriteLine("My favorite language is" + favoriteLanguage);
        Console.WriteLine("Number of programs written before this is" + programsWritten);
        Console.WriteLine("Do I have programming experience: " + haveExperience);

        //Step 4
        const string schoolName = "The Ohio State University";
        Console.WriteLine("My college is " + schoolName);

        //Step 5
        double doubleValue = 9.78;
        int intValue = (int)doubleValue;
        Console.WriteLine("OG double: " + doubleValue);
        Console.WriteLine("Casted to int: " + intValue);

        string intAsString = Convert.ToString(intValue);
        Console.WriteLine("Int to String: " + intAsString);

        bool isStudent = true;
        string boolAsString = Convert.ToString(isStudent);
        Console.WriteLine("Boolean to String: " + boolAsString);

        //Step 6
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Greetings " + userName + ", you are " + userAge + " years old. ");

        //Step 7
        int num1 = 7;
        int num2 = 10;

        Console.WriteLine("Addition: " + (num1 + 10));
        Console.WriteLine("Subtraction: " + (num2 - 2));
        Console.WriteLine("Multiplication: " + (num1 * 3));
        Console.WriteLine("Division: " + (num2 / 2));
        Console.WriteLine("Modulus: " + (num1 % 2));

        //Step 8
        float floatValue = 1.123456789f;
        double doubleeValue = 1.123456789;

        Console.WriteLine("Float value: " + floatValue);
        Console.WriteLine("Double value: " + doubleeValue);

        //Step 9
        int count = 10;
        count++;
        Console.WriteLine("After incriment: " + count);
        count--;
        Console.WriteLine("After decrement: " + count);
    }
}
