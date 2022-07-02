void Zadacha15(int numb)
{
    if(numb == 6)
    {
        Console.WriteLine("Да");
    }
    else if(numb == 7)
    {
        Console.WriteLine("Да");
    }
    else if(numb < 1)
    {
        Console.WriteLine("Такого дня недели нет");
    }
    else if(numb > 7)
    {
        Console.WriteLine("Такого дня недели нет");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}   

Console.WriteLine("Введите цифру дня недели, а я скажу является ли этот день выходным:");
int number = Convert.ToInt32(Console.ReadLine());
Zadacha15(number);