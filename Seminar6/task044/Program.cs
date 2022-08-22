// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите количество чисел Фибоначи: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] Fibonnachi = new int [number];

Fibonnachi[0]=0;
Fibonnachi[1]=1;
for (int i = 2; i < Fibonnachi.Length; i++)
{
    Fibonnachi[i]= Fibonnachi[i-1] + Fibonnachi[i-2];
}
Console.WriteLine(string.Join(" ", Fibonnachi));