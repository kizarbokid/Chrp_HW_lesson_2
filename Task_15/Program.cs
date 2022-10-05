// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Input weekday's number: ");
int is_weekday = Convert.ToInt32(Console.ReadLine());

switch (is_weekday) // Проще через if, через switch..case решила в целях практики
{
    case 1: Console.WriteLine("Weekday"); break;
    case 2: Console.WriteLine("Weekday"); break;
    case 3: Console.WriteLine("Weekday"); break;
    case 4: Console.WriteLine("Weekday"); break;
    case 5: Console.WriteLine("Weekday"); break;
    case 6: Console.WriteLine("Holiday"); break;
    case 7: Console.WriteLine("Holiday"); break;
    default: Console.WriteLine("I know just 7 days of the week"); break;
}
