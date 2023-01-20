//  Напишите программу, которая 
//  1 принимает на вход число и 
//  2 выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Podchetcift(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void Summacifr(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
int Vyvod(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Vyvod("Введите число: ");
int len = Podchetcift(number);
Summacifr(number, len);

