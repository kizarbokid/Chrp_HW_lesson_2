// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Write some numbers and press ENTER");
string text = Console.ReadLine();

if (int.TryParse(text, out var number)) //  TryParse проверяет, можно ли выполнить операцию 
{ // по преобразованию переменной text в переменную number типа integer. если true, то ..
    if (text.Length <= 2)
    {
        Console.Write("There is no third symbol");
    }
    else
    {
        Console.WriteLine(text.Substring(2, 1));
    }
}
else Console.Write("This is not a number");
