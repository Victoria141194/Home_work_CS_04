int[] array = new int[8];
int num1 = FillArray("Введите первое число массива: ");
int num2 = FillArray("Введите второе число массива: ");
int num3 = FillArray("Введите третье число массива: ");
int num4 = FillArray("Введите четвертое число массива: ");
int num5 = FillArray("Введите пятое число массива: ");
int num6 = FillArray("Введите шестое число массива: ");
int num7 = FillArray("Введите седьмое число массива: ");
int num8 = FillArray("Введите восьмое число массива: ");

Console.WriteLine($"array -> [{num1}, {num2}, {num3}, {num4}, {num5}, {num6}, {num7}, {num8}]");

/////////////////////////////////////////////////////
int FillArray(string message)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
    }
}

