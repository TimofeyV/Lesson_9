// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int[] CreateArray(string message1, string message2) // Вывод сообщений и создание числа
{
    Console.Write(message1);
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.Write(message2);
    int numberM = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[2] {numberN, numberM};
    return arr;

}

int Recursia(int startNumber, int endNumber) // Вывод суммы чисел от N до M
{
   if(startNumber == endNumber) return startNumber;
   else
   {
        return startNumber += Recursia(startNumber + 1, endNumber);
   }
}


int [] arr = CreateArray("Введите N: ", "Введите M: ");
Console.WriteLine(Recursia(arr[0], arr[1]));