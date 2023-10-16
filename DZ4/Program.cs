Console.WriteLine("Введите число");
string num1 = Console.ReadLine();
int got1 = Convert.ToInt32(num1);
int num2 = 1;
for(int N = num2; N <= got1; N++)
{
    int got2 = 2;
    int result = N % got2;
    if(result == 0)
    {
        Console.Write(N);
    }

}
// int array = {1, got1}; 
// int index0 = 1;
// int size = got1;
// int currentidex = index0;
// string otvet2 = otvet, + "" +;
// while(array[currentindex] < got1)
// {
//     if(currentidex == index[size - 1])
//     {
//         Console.WriteLine(otvet2);
//     }
//     currentidex++;
//     string otvet = array[currentidex++];
// }
