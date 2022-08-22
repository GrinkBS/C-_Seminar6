// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Какое количество чисел вы хотите ввести? ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = new int [number];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Введите число -> ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    arr[i]= number1;
}
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>0)
    {
      count = count +1;  
    }
}
Console.WriteLine($"{string.Join(", ", arr)} -> {count}");


