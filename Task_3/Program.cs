//  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.Write("Введите двухзначное число  ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10 || number > 99)
{
    Console.Write("Введено не двухзначное число или отрицательное число");
}
else
{
    int num1 = number % 10;
    int num2 = number / 10;
    if (num1 > num2)
    {
        Console.Write($"Цифра {num1} наибольшая из числа {number}");
    }
    else
    {
        Console.Write($"Цифра {num2} наибольшая из числа {number}");
    }
}