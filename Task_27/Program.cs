Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int num = int.Parse(userInput);
int sum = 0;

while (num > 0)
{
    int n = num % 10;
    sum = sum + n;
    num = num / 10;
}
Console.WriteLine($"{userInput} -> {sum}");