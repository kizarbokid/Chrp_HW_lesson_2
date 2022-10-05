// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Shift + Alt + F - отформатировать код
Console.WriteLine("Write some three symbols and press ENTER");
string text = Console.ReadLine();

Console.WriteLine("Now you will see the second sybmbol");
Console.WriteLine(text.Substring(1, 1));// Substring (1,1)- подстрока (с 1ого символа начиная обрезать 1 символ)
