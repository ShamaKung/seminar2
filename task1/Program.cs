// 1 решение


/*

Console.WriteLine("Введите 3-х значное число");
string a = Console.ReadLine();
int alength = a.Length;

if(alength == 3)
{
    Console.WriteLine(a[1]);
}
else
{
    Console.WriteLine("Неверный формат числа");
}

*/



// 2 решение


Console.WriteLine("Введите 3-х значное число");
string a = Console.ReadLine();
int alength = a.Length;
int digital = Convert.ToInt32(a);

if(alength == 3)
{
    int result = digital % 100 / 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Неверный формат числа");
}


