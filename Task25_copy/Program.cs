// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень В

Console.Clear();

Console.Write("Введите число А: ");
int numA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число В: ");
int numВ = int.Parse(Console.ReadLine()!);

int result = 1;

for (int i = 1; i <= numВ; i++)
    {
        result = result * numA;
    }
Console.WriteLine(result);