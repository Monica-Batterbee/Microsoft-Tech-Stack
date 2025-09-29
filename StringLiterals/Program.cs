using System;

class Program
{
    static string _value1 = "String literal";
    const string _value2 = "String literal 2";
    const string _value3 = "String literal 3\r\nAnother line";
    const string _value4 = @"String literal 4
    Another line";
    const string _value5 = "String literal\ttab";
    const string _value6 = @"String literal\ttab";


    static void Main()
    {
        string test1 = "String literal \"1\"";
        const string test2 = "String literal 2";
        string test3 = @"String literal ""3""";
        const string test4 = @"String literal 4";

        const string test = "Test1";
        string testt = "Test2";
        //test = testt;   <- This line would break the program as test has been set to a constant
        Console.WriteLine($"test {test}");

        Console.WriteLine(
            "{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}",
            _value1, _value2, _value3, _value4, _value5, _value6,
            test1, test2, test3, test4);
    }
}
