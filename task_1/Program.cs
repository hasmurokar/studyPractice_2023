int[] arr = { 5, -10, 20, -30, 15 };
int minModuloNeg = int.MaxValue;
int minModuloNegIndex = -1;
Console.WriteLine("Начальный массив");
foreach (int num in arr)
{
    Console.Write($"{num} ");
}

Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0 && Math.Abs(arr[i]) < minModuloNeg)
    {
        minModuloNeg = Math.Abs(arr[i]);
        minModuloNegIndex = i;
    }
}

if (minModuloNegIndex != -1)
{
    arr[minModuloNegIndex] = arr[0];
}
Console.WriteLine("Измененный массив");
foreach (int num in arr)
{
    Console.Write($"{num} ");
}