int num1 = GetNumberFromUser("Введите первое число: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите второе число: ", "Ошибка ввода!");
double power = GetPowerOfNumber(num1, num2);

Console.WriteLine($"{num1}, {num2} -> {power}");

//////////////////////////////////////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


double GetPowerOfNumber(int num1, int num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}
 