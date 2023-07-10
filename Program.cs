// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();
int ReadInt(string message)
{
    System.Console.Write($"{message}: ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int GetSumNums(int M, int N)
{
    int Sum = M;
    if (M == N) return 0;
    else
    {
        M++;
        Sum = M + GetSumNums(M, N);
        return Sum;
    }
}

int NumFirst = ReadInt("Введите первое число");
int NumLast = ReadInt("Введите второе число");
System.Console.WriteLine(GetSumNums(NumFirst - 1, NumLast));