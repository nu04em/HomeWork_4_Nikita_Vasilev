// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Вариант 1.
Console.Clear();

Console.Write("Введите число: ");
string num = Console.ReadLine();

int sum = 0;

for (int i = 0; i < num.Length; i++)
    {
        // sum += int.Parse(string.Join("", num[i])!);
        sum  += int.Parse(num[i].ToString()!);
    }

Console.Write($"Сумма цифр введенного числа равна: {sum}");

// Вариант 2.

// Console.Clear();

// Console.Write("Введите число: ");
// string num = Console.ReadLine();

// int sum = 0;

// while (num != 0) 
//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
// Console.Write($"Сумма цифр введенного числа равна: {sum}");