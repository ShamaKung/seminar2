// 1 решение


/*

Console.WriteLine("Введите число");
string a = Console.ReadLine();
int alength = a.Length;

if(alength >= 3)
{
    Console.WriteLine(a[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

*/



// 2 решение
// долго думал как решить, потом искал как подключить Math, не совсем уверен в синтаксисе, но работает х)


Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int k = (int)Math.Log10(n)-2;

if(k < 0)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine((n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
}