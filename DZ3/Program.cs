Console.WriteLine("Введите число!");
string numberA = Console.ReadLine();
int got1 = Convert.ToInt32(numberA);
int got2 = 2;
int result = got1 % got2;
if(result == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}