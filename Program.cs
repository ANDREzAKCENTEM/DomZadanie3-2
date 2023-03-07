// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = FirstNumber(number);

// int FirstNumber(int num)
// {
//     int firstDigit = num / 10;
//     int lastDigit = num % 100;
//     int result = lastDigit / 10;
//     return result;
// }
// Console.WriteLine($"{result}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = (int)Math.Log10(number) - 2;
// Console.WriteLine(result < 0 ? "третьей цифры нет " : (number % (int)Math.Pow(10, result + 1) / (int)Math.Pow(10, result)));

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 6)
{
    Console.WriteLine("нет");
}
else if (number == 6)
{
    Console.WriteLine("да");
}
// else if (number == 3)
// {
//     Console.WriteLine("нет");
// }
// else if (number == 4)
// {
//     Console.WriteLine("нет");
// }
// else if (number == 5)
// {
//     Console.WriteLine("нет");
// }
// else if (number == 6)
// {
//     Console.WriteLine("да");
// }
else if (number == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Введите цифру от 1 до 7!");
}
