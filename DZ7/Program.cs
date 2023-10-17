Console.WriteLine("Введите число!");
int x = Convert.ToInt32(Console.ReadLine());
string Ponedelnik = "Понедельник";
string Vtornik = "Вторник";
string Sreda = "Среда";
string Chetverg = "Четверг";
string Pyatniza = "Пятница";
string Subbota = "Суббота";
string Voskrsenye = "Воскресенье"; 
int Pon = 1;
int Vtor = 2;
int Sred = 3;
int Chet = 4;
int Pyat = 5;
int Sub = 6;
int Vos = 7;
if(x < 1 || x >7)
{
    Console.WriteLine("Введите число от 1 до 7");
}
if(Pon == x) Console.WriteLine("Нет " + Ponedelnik);
if(Vtor == x) Console.WriteLine("Нет " + Vtornik);
if(Sred == x) Console.WriteLine("Нет " + Sreda);
if(Chet == x) Console.WriteLine("Нет " + Chetverg);
if(Pyat == x) Console.WriteLine("Нет " + Pyatniza);
if(Sub == x) Console.WriteLine("Да " + Subbota);
if(Vos == x) Console.WriteLine("Да " + Voskrsenye);

