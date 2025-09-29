// See https://aka.ms/new-console-template for more information
using System.Text;

string word = "hello";
Console.WriteLine($"The string {word} takes up {Encoding.UTF8.GetByteCount(word)} bytes in memory");

int num = 3;
Console.WriteLine($"The integer {num} takes up {sizeof(int)} bytes in memory");

float dec = 2.5f;
Console.WriteLine($"The float {dec} takes up {sizeof(float)} bytes in memory");

char a = 'a';
Console.WriteLine($"The character {a} takes up {sizeof(char)} bytes in memory");

bool t = true;
Console.WriteLine($"The boolean {t} tales up {sizeof(bool)} bytes in memory");
