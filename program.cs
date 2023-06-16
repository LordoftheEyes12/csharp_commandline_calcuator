using System;
using System.Text.RegularExpressions;

static class Program
{

    static void Main(string[] args)
    {

        if (args.Length == 3)
        {
            try
            {
                double num1 = Convert.ToDouble(args[0]);
                double num2 = Convert.ToDouble(args[2]);
                double result;
                string op = args[1];
                result = Rechenoperationen.calc(num1, num2, op);
                Console.WriteLine(result);
            }
            catch (Exception fail)
            {

                Console.WriteLine(fail);
            }
        }
        else if (args.Length == 1) 
        { 
            string input = args[0];
            if (input.Contains("."))
            {
                input = input.Replace(".", ",");
            }
            string pattern = @"([0-9]+(\,[0-9]+)?)(\D+)([0-9]+(\,[0-9]+)?)";

            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                double firstNumber = double.Parse(match.Groups[1].Value);
                string op = match.Groups[3].Value.Trim();
                double secondNumber = double.Parse(match.Groups[4].Value);
                double result = Rechenoperationen.calc(firstNumber, secondNumber, op);
                string ausgabe = result.ToString("0.00");
                Console.WriteLine(ausgabe);
            }
        }
        else if (args.Length == 2)
        {

            string input = args[0];
            if (input.Contains("."))
            {
                input = input.Replace(".", ",");
            }
            string pattern = @"([0-9]+(\,[0-9]+)?)(\D+)([0-9]+(\,[0-9]+)?)";
            string commandlineArgument = args[1];
           
       
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                double firstNumber = double.Parse(match.Groups[1].Value);
                string op = match.Groups[3].Value.Trim();
                double secondNumber = double.Parse(match.Groups[4].Value);
                double result = Rechenoperationen.calc(firstNumber, secondNumber, op);
                if (commandlineArgument == "-d"||commandlineArgument == "-D")
                {
                    Console.WriteLine(result.ToString());
                }
                else if (commandlineArgument.StartsWith("-"))
                {
                    
                    string decimalPlaces = commandlineArgument.Substring(1);
                    bool isNumeric = int.TryParse(decimalPlaces, out int number);
                    if (isNumeric)
                    {
                        string ausgabe = result.ToString($"F{decimalPlaces}");
                        Console.WriteLine(ausgabe);
                    }
                    else
                    {
                        Console.WriteLine("ungültiges Command-Line-Argument");
                    }
                }
                else
                {
                    string ausgabe = result.ToString("0.00");
                    Console.WriteLine(ausgabe);
                }
            }
        }

    }
}