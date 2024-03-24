

string Test(int first,int second)
{
    if(second == 0){return " Devision by 0!!!";}
    int result = first % second;
    if(result == 0){return " YES ";}
    else{ return ($" NO, {result}"); }
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Test(a,b));