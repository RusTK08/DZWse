Console.WriteLine("Введите число!");
string numberOne = Console.ReadLine();
int gotov = Convert.ToInt32(numberOne);
Console.WriteLine("Введите число 2!");
string numberTwo = Console.ReadLine();
int gotov2 = Convert.ToInt32(numberTwo);
int max = gotov;
int min = gotov2;
if(gotov == gotov2) 
{
    Console.WriteLine("Введите число не равное другому"); 
}
else if(gotov > gotov2) 
{
    max = gotov; min = gotov2;
    Console.Write("Максимальное ");
    Console.WriteLine(max );
    Console.Write("Минимальное ");
    Console.WriteLine(min );
}
else
{
    max = gotov2; min = gotov;
    Console.Write("Максимальное ");
    Console.WriteLine(max );
    Console.Write("Минимальное ");
    Console.WriteLine(min );
}