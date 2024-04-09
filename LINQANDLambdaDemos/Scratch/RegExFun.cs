// C# program to validate the Mobile
// Number using Regular Expressions
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RegExFun
{
    public static void SimpleRegExExamples()
    {
        Console.WriteLine($"Strings starting with 'the'...");
        string strRegEx = "^[Tt][Hh][Ee]";
        Regex re = new Regex(strRegEx);
        List<string> strings = new List<string>() {"The", "the", "THE", "they", "thy", "A thesaurus", "other" };
        foreach (string phrase in strings) {
            if (re.IsMatch(phrase)){
                Console.WriteLine(phrase);
            }
        }

        Console.WriteLine("strings that contain 'the'...");
        strRegEx = ".*[Tt][Hh][Ee].*";
        re = new Regex(strRegEx);
        strings.Clear();
        strings = new List<string>() { "The", "the", "THE", "they", "thy", "A thesaurus", "other" };
        foreach (string phrase in strings)
        {
            if (re.IsMatch(phrase))
            {
                Console.WriteLine(phrase);
            }
        }
    }

    public static void PhoneNumberValidation()
    {
        // Input strings to Match
        // valid mobile number
        string[] str = {"9925612824",
        "8238783138", "02812451830"};
        Console.WriteLine("Phone number validation...");
        foreach (string s in str)
        {
            Console.WriteLine("{0} {1} a valid mobile number.", s,
                        isValidMobileNumber(s) ? "is" : "is not");
        }

        Console.ReadKey();
    }

    // method containing the regex
    public static bool isValidMobileNumber(string inputMobileNumber)
    {
        string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
				{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

        // Class Regex Represents an
        // immutable regular expression.
        // Format			 Pattern
        // xxxxxxxxxx		 ^[0 - 9]{ 10}$
        // +xx xx xxxxxxxx	 ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$
        // xxx - xxxx - xxxx ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$
        Regex re = new Regex(strRegex);

        // The IsMatch method is used to validate
        // a string or to ensure that a string
        // conforms to a particular pattern.
        if (re.IsMatch(inputMobileNumber))
            return (true);
        else
            return (false);
    }
}

