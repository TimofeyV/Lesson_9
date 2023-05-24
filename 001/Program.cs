// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int CreateNumber(string message) // Вывод сообщений и создание числа
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string Recursia(int startNumber) // Вывод всех натуральных чисел от N до 1
{
    int endNumber = 1;
    if(startNumber == endNumber) return startNumber.ToString();
    if (startNumber > endNumber)
    {
        return (startNumber + " " + Recursia(startNumber-1));
    }
    return (startNumber + " " + Recursia(startNumber+1));
}

int N = CreateNumber("Введите число: ");
Console.WriteLine(Recursia(N));