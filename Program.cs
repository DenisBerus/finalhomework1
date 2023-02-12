string[] Massiv;
Console.WriteLine("Введите любые значения (цифры и слова) через пробел");
string stroka = Console.ReadLine();
Massiv = stroka.Split(' ');
var result = new string[Massiv.Length];
var realSize = 0;
foreach (var value in Massiv)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));


