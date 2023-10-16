Console.WriteLine("Введите число 1!");
string numberA = Console.ReadLine();
int got1 = Convert.ToInt32(numberA);
Console.WriteLine("Введите число 2!");
string numberB = Console.ReadLine();
int got2 = Convert.ToInt32(numberB);
Console.WriteLine("Введите число 3!");
string numberC = Console.ReadLine();
int got3 = Convert.ToInt32(numberC);
if(got1 == got2 && got1 == got3) 
{
    Console.WriteLine("Введите число не равное другому"); 
}
else
{
    int Max(int got1, int got2, int got3)
{
    int result = got1;
    if(got2 > result) result = got2;
    if(got3 > result) result = got3;
    return result;
}
    int max = Max(got1, got2, got3);
    Console.Write("Максимальное число ");
    Console.WriteLine(max);
}