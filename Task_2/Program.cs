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
    string numbers = number.ToString();
    char thirdNumber = numbers[2];
    System.Console.WriteLine($"В введенном числе {number} третьей цифрой является > {thirdNumber}");
}