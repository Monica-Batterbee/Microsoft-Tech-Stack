// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

static string ConcatString(string str1, string str2)
{
    string result = string.Concat(str1, " ", str2);
    Console.WriteLine(result);

    return result;
}

static string ReplaceString(string str1, string replace, string replaceWith)
{
    string result = str1.Replace(replace, replaceWith);
    Console.WriteLine(result);

    return result;
}


static string UpperString(string str)
{
    string result = str.ToUpper();
    Console.WriteLine(result);

    return result;
}

string concatResult = ConcatString("Hello", "World!");
string replaceResult = ReplaceString(concatResult, "World!", "User!");
string upperResult = UpperString(replaceResult);

