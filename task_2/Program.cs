int n = 15;
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    arr[i] = rand.Next(-100, 100);
}
foreach (var item in arr)
{
    Console.Write(item + ", ");
}
int sum = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] > 0 && arr[i] < 10)
    {
        sum += arr[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов, значения которых меньше 10: {sum}");

Console.Write("Индексы элементов значения которых кратны 3 и 5: ");
for (int i = 0; i < n; i++)
{
    if (arr[i] % 3 == 0 && arr[i] % 5 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

int givenNum = 0;
Console.Write("Введите целое число: ");
givenNum = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n - 1; i++)
{
    if (arr[i] + arr[i + 1] == givenNum)
    {
        Console.WriteLine($"Паара соседних элементов с суммой райной {givenNum} это элементы с индексами {i} и {i + 1}");
        break;
    }
}
