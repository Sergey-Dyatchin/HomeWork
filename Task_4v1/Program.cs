// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// Простое решение 
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int numberCopy = number;
while (numberCopy > 0)
{
    Console.Write(numberCopy % 10);
    numberCopy /= 10;
    if (numberCopy > 0)
    {
        Console.Write(", ");
    }
}
