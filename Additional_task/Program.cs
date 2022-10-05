// Дан список чисел, необходимо удалить все вхождения числа 20 из него и вывести его в обратном порядке.
Console.Clear();
int[] numbers = { 20, 2, 3, 4, 20, 6, 7, 8, 20, 10 };
int n=0,
    i = 0,
    j=0;

for (i = 0; i < numbers.Length-1; i++)
    if (numbers[i] == 20) //Если значение ==20, тогда
    {   n = n+1; // Счетчик повторений числа 20 прирастим на 1

        for (j = i; j < numbers.Length - 1; j++) // затрем этот элемент и до конца массива значением следующего элемента
            numbers[j]=numbers[j+1];    
    }
    
Array.Resize(ref numbers, numbers.Length -n); // изменить размерность на минус эн
Array.Reverse(numbers);                       // Перевернуть элементы

foreach (int k in numbers) // вывод на экран
{
    Console.Write($"{k}--");
}