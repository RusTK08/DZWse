Console.WriteLine("Введите число!");
string num1 = Console.ReadLine();
int exe = Convert.ToInt32(num1);
if(exe >99 && exe <1000)
{
    int result = exe % 100;
    int result2 = result / 10;
    Console.WriteLine(result2);
}
else
{
    Console.WriteLine("Введите число больше 99 и меньше 1000");
}
// Console.WriteLine("Введите число!");
// string num1 = Console.ReadLine();
// int exe = Convert.ToInt32(num1);
// int array{} = exe;
// Console.WriteLine(array);
