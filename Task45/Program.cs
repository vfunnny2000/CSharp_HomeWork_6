// Напишите программу, которая будет создавать копию заданного массива
//  с помощью поэлементного копирования.
int[] array = new int[10];
int arrayCopy;

Console.Write("Оригинал ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 50);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("   Копия ");
// Console.ResetColor();
for (int i = 0; i < array.Length; i++)
{
    arrayCopy = array[i];
    Console.Write(arrayCopy + " ");
}
Console.ResetColor();