// Console.WriteLine("Введите число!");
// int numA = Convert.ToInt32(Console.ReadLine());
// if(numA > 99 || numA < -99)
// {
//     int result = numA % 10;
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// Console.WriteLine("Введите число");
// int Number = Convert.ToInt32(Console.ReadLine());
// string NumberP = Convert.ToString(Number);
// if (NumberP.Length > 2)
// {
//   Console.WriteLine(NumberP[2]);
// }
// else 
// {
//   Console.WriteLine("Третьей цифры нет");
// }
Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberP = Convert.ToString(Number);
int index = 0;
int poryadkovNumberIskom = 3;
int raznica = 1;
int indexFind = poryadkovNumberIskom - raznica;
if(NumberP.Length > indexFind) 
{
    Console.WriteLine(NumberP[indexFind]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}