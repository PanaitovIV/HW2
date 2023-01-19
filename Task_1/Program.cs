// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool ValidateNumberRank3(int number)
{
    if (number > 99 && number < 1000)
    {
        return true;
    }
    System.Console.WriteLine("Число не является трехзначным!");
    return false;
}

int number = InputInt("Введите трехзначное число");
if (ValidateNumberRank3(number))
{
int twoRank =  (number / 10) % 10;
System.Console.WriteLine($"Вторая цифра числа {number} является цифра - {twoRank}");
}