// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

Console.Clear();

int[] array = new int[8];

string[] words = {"первое", "второе", "третье", "четвертое", "пятое", "шестое", "седьмое", "восьмое"};

for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {words[i]} число {i + 1}/{array.Length}: ");
        int num = int.Parse(Console.ReadLine()!);
        array[i] = num;
    }

Console.WriteLine($"Результат: [{string.Join(", ", array)}]");