﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int lengthArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lengthArray];


for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,8);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}