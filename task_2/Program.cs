

using System.Runtime.InteropServices;

int num = new Random().Next(100,1000);
Console.WriteLine($"  Number :: {num}");
int numTens = num / 10 % 10;
int numUnits = num % 10;
int result;


Console.WriteLine($" Result == {Math.Pow(numTens,numUnits)}");

