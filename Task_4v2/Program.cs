// Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
//вывод циф в томже порядке, что и в числе
Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int numberCopy = number;
int numberTemp = numberCopy;
int score = 0;
while (numberCopy > 9)
{
    numberTemp = numberCopy;
    score = 0;
    while (numberTemp > 9)
    {
        numberTemp /= 10;
        score ++;
    }
    Console.Write(numberTemp);
    numberCopy = numberCopy - (numberTemp * Convert.ToInt32(Math.Pow(10, score)));
    Console.Write(", ");
}
Console.Write(numberCopy);