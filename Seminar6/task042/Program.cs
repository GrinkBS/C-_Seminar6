// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

GetBinaryView(number);

void GetBinaryView(int N)
{
    if (N <=0) return; //return - если число рано нулю, то делаем выход
    GetBinaryView(N/2);//будет считать N/2 до нуля, почле чего начнет в обратном порядке делать Console.Write(N%2)
    Console.Write(N%2);
}