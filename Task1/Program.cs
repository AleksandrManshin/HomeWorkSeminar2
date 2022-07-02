void Zadacha13(string numb)
{
    if(numb.Length > 2)
    {
        Console.WriteLine(numb[2]);
    }
    else
    {
        Console.WriteLine("В числе третьей цифры нет");
    }
}

Console.Write("Введите число:");
string number = Console.ReadLine();
Zadacha13(number);