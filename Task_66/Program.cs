/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int getIntFromUser(string message)  
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int userNumberM = getIntFromUser("Введите начальное значение М ");
int userNumberN =getIntFromUser ("Введите конечное значение N ");
int Sum = getSumMN( userNumberM, userNumberN);
Console.Write(Sum);

int getSumMN (int m, int n)
{
    return m == n? n : m + getSumMN(m + 1, n);
}

