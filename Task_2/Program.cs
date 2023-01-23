// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

bool FindThirdNumber(int number)
{
	if(number > 99)
    {
        return true;
    }
    System.Console.WriteLine("В данном числе нет третьей цифры!");
	return false;
}

int number = InputInt("Введите любое целое число");
if (FindThirdNumber(number))
{
    while (number > 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    System.Console.WriteLine($"Третьей цифрой в заданнном числе является > {number}");
}