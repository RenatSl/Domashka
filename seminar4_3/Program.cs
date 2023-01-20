// Задача29 Напишите программу, 
// 1 которая задаёт массив из 8 элементов и 
// 2 выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(10);
    }
}

void PrintArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"[{collection[i]}]");
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);