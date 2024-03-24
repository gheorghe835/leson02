
int num = new Random().Next(100,10000);
Console.WriteLine($"  Number :: {num}");
int res;
if(num > 100 && num < 1000)
{
    res = num % 10;
    Console.WriteLine($"  Number :: {res}");
}
if(num > 1000 && num < 10000)
{
    res = num / 10 % 10;
    Console.WriteLine($"  Number :: {res}");
}
else
{
     Console.WriteLine("The third number doesn't exist");
}
