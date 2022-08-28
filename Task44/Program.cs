// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int n = 0;
List<int> numbers = new List<int>();

while (true)
{
    Console.Write("Введите кол-во чисел в последовательности: ");
    int.TryParse(Console.ReadLine(), out n);


    if (n < 2)
    {
        Console.WriteLine("минимальное кол-во чисел - 2.");
        Console.ReadKey(true);
        Console.Clear();
    }
    else
    {
        numbers.Add(0);
        numbers.Add(1);
        break;
    }
}

for (int i = 0; i < (n - 2); i++)
    numbers.Add(numbers[numbers.Count - 1] + numbers[numbers.Count - 2]);

foreach (int tmp in numbers)
    Console.Write(tmp + " ");

Console.ReadKey(true);