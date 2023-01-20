// Задача 25: 
// 1.Напишите цикл, который принимает на вход два числа (A и B) 
// 2.и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void ToAB(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
int Stepen(string message)
{
    Console.WriteLine(message);
    return
    Convert.ToInt32(Console.ReadLine());
}
int numberA = Stepen("Введите число A: ");
int numberB = Stepen("Введите число B: ");
ToAB(numberA, numberB);
