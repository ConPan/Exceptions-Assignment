using Exceptions_Assignment;
using System.Runtime.Intrinsics.X86;
using System.Threading;


string filePath = "C:\\Users\\deltagaren\\source\\repos\\Exceptions Assignment\\Exceptions Assignment\\Names.txt"; // Specify the path and filename for the CSV file                                                                                                                              // Sample data
////////    First step:    ///////
// Write a method that takes a string as parameter and returns a list of numbers in order of highest to lowest. 
// The string is thought of as containing an amount of numbers. Use a string method to transfer the string into
// an array. Use Int.Parse when translating each string in the array to an int in a list. Use the try-catch
// pattern when translating string to int (for this assignment and for training purpose, don’t use
// the tryParse method.) Check for FormatException and if catched, write “Entry discarded” to the Console.

// First step of the assignment starts here:
Console.WriteLine("First step: Converted numbers with Entry discarded numbers");

List<int> ExtractAndSortNumbers(string inputStringToBeParsed)
{
    string[] numberStrings = inputStringToBeParsed.Split(',');
    List<int> numberList = new List<int>();         
    // Foreach that populates the list with integers 
    foreach (string numStr in numberStrings)
    {
        try
        {
            int number = int.Parse(numStr);                    // from string to integer
            numberList.Add(number);                            // adds integers to the list
        }
        catch (FormatException)
        {
            Console.WriteLine("Entry discarded: " + numStr);   // logs the format exception
        }
    }
    numberList.Sort((a, b) => b.CompareTo(a));                 // Sorts the list in descending order
    return numberList;                                         // return a list of integers
}



// inputStringToBeParsed:
string inputStringToBeParsed = "10, 5, 2, 8, abc, 12, 6";

// List to store the extracted numbers:
List<int> outputNumbers = ExtractAndSortNumbers(inputStringToBeParsed);

foreach (int num in outputNumbers)
{
    Console.WriteLine(num);
}


////////    Second step:    ///////
// Add a WordsDTO class. It should have three properties:
// • a string array
// • a bool
// • a string
// The DTO stands for data transfer object and means an object that only serves as a tool for transfer
// and will not be kept after it has been used. 


////////    Third step:    ///////
//Write a method that takes a file path as a string parameter and returns a WordsDTO object. 
//The file path should be used to read text from a file on the computer. The text is expected to be a
//comma separated text. When read, make a string array of the words separated by the commas (the commas
//should be discarded.) Use the try-catch pattern for looking up the file with the file path.
//Catch if the file is not found. If so, set the bool to false and set the string to “File not found”. 
//If no problem is catched, set the bool to true and set the string to “Success”.

Console.WriteLine("\nThird step: ");

WordsDTO wordsDTOobject = Utility.ReadWordsFromFile(filePath);
string number1 = wordsDTOobject.ArrayOfStrings[1];
Console.WriteLine("number1: " + number1);
string number2 = wordsDTOobject.ArrayOfStrings[2];
Console.WriteLine("number2: " + number2);
string number3 = wordsDTOobject.ArrayOfStrings[3];
Console.WriteLine("number3: " + number3);
string number4 = wordsDTOobject.ArrayOfStrings[4];
Console.WriteLine("number4: " + number4);





























///////////////////////////////////////////////////////////////////////////////////////
//string inputString = "7, 2, 45, 76, 16, 5, 29";
//List<int> sortedNumbers = NumbersFromString.MyMethod(inputString);
//Console.WriteLine("Sorted Numbers (Highest to Lowest):");
//foreach (int number in sortedNumbers)
//{
//    Console.WriteLine(number);
//}


//class NumbersFromString
//{
//    public static List<int> MyMethod(string inputString)
//    {
//        // Initialize an empty list to store the extracted numbers.
//        List<int> outputNumbers = new List<int>();

//        // Split the input string into words and check each word for numbers.
//        string[] wordsFromInputString = inputString.Split(',');

//        //foreach (string word in words)
//        //{

//        //    if (int.TryParse(word, out int number))
//        //    {
//        //        // If the word can be parsed as an integer, add it to the list.
//        //        outputNumbers.Add(number);
//        //    }
//        //}

//        foreach (string numberAsString in wordsFromInputString)
//        {
//            try
//            {
//                // Use int.Parse to convert the string to an integer and add it to the list.
//                int number = int.Parse(numberAsString);
//                outputNumbers.Add(number);
//            }
//            catch (FormatException)
//            {
//                // Handle cases where parsing fails (e.g., non-integer strings).
//                Console.WriteLine($"Unable to parse: {numberAsString}");
//            }
//        }

//        // Sort the list of numbers in descending order.
//        outputNumbers.Sort((a, b) => b.CompareTo(a));

//        return outputNumbers;
//    }
//}




////////////////////////////////////////////////////////////////////////////////////
///
//string input = "10, 3, 21, 15, invalid 25";

//List<int> convertedNumbers = NumberExtractor.ExtractAndConvertNumbers(input);

//Console.WriteLine("Converted Numbers:");
//foreach (int number in convertedNumbers)
//{
//    Console.WriteLine(number);
//}













//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class NumberExtractor
//{
//    public static List<int> ExtractAndSortNumbers(string input)
//    {
//        // Initialize an empty list to store the extracted numbers.
//        List<int> numbers = new List<int>();

//        // Split the input string into words and check each word for numbers.
//        string[] words = input.Split(' ');
//        foreach (string word in words)
//        {
//            if (int.TryParse(word, out int number))
//            {
//                // If the word can be parsed as an integer, add it to the list.
//                numbers.Add(number);
//            }
//        }

//        // Sort the list of numbers in descending order.
//        numbers.Sort((a, b) => b.CompareTo(a));

//        return numbers;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        string input = "This is a sample string with numbers 10, 5, and 20";

//        List<int> sortedNumbers = NumberExtractor.ExtractAndSortNumbers(input);

//        Console.WriteLine("Sorted Numbers (Highest to Lowest):");
//        foreach (int number in sortedNumbers)
//        {
//            Console.WriteLine(number);
//        }
//    }
//}
