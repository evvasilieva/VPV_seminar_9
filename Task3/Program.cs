﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Ackerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackerman(n - 1, 1);
    else
      return Ackerman(n - 1, Ackerman(n, m - 1));
}

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

int n = ReadData("Введите число N: ");
int m = ReadData("Введите число M: ");

int sumAckerman = Ackerman(n, m);

PrintData("значение функции Аккермана равно: ", sumAckerman);