// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int FuncStrToInt(string input) 
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintRecurs(int N, int count)
{
    if (count > N) return;
    PrintRecurs(N, count + 1);
    Console.Write(count + ", ");
}

Console.Clear();
int N = FuncStrToInt("Введите число N: ");
int count = 2;
PrintRecurs(N, count);
Console.Write(1);

