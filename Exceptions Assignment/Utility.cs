using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Assignment
{
    public class Utility
    {
        public static WordsDTO ReadWordsFromFile(string filePath)
        {
            WordsDTO result = new WordsDTO();

            try
            {
                string fileContent = File.ReadAllText(filePath);
                string[] words = fileContent.Split(',');

                result.ArrayOfStrings = words;
                result.IsEnabled = true;
                result.MyString = "Success";
                Console.WriteLine("result: " + result.MyString);
            }
            catch (Exception exception)
            {
                result.IsEnabled = false;
                result.MyString = $"Error: {exception.Message}";
                result.MyString = "File not found";
                Console.WriteLine("result: " + result.MyString);
            }

            return result;
        }
    }
}



