// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int numberday = InputInt("Введите цифру, обозначающую день недели");

CheckingTheDayOfTheWeek(numberday);

void CheckingTheDayOfTheWeek (int numberday)
{
if (numberday == 6 || numberday == 7) 
{
    System.Console.WriteLine("Этот день является выходным!");
}
else
if (numberday < 1 || numberday > 7) 
{
    System.Console.WriteLine("Ошибка! Это не день недели!");
}
else System.Console.WriteLine("Этот день не является выходным!");
}