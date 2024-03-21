using System.Runtime.InteropServices;

int num = new Random().Next(100,1000);
Console.WriteLine($"  Number :: {num}");
int numHundreds = num / 100;
int numUnits = num % 10;
int numTens = num / 10 % 10;
Console.WriteLine(" -------- ");
Console.WriteLine($" Hundreds :: {numHundreds}");
Console.WriteLine($" Tens :: {numTens} ");
Console.WriteLine($" Units :: {numUnits}");
Console.WriteLine(" -------- ");
Console.WriteLine($"{numHundreds}{numUnits}");
Console.WriteLine($"{numHundreds}{numTens}{numUnits}");

string num_str = Convert.ToString(num);
Console.WriteLine(Convert.ToString(num_str[0])+
                  Convert.ToString(num_str[2]));

