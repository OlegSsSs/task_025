// Напишите цикл, который принимает на вход два числа A и B и возводит число A в натуральную степень B
// 3, 5 -> 243
// 2, 4 -> 14

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int degr = A;

for (int i = 1; i < B; i++)
{
degr = degr * A;
}
Console.WriteLine("A в степени B = " + degr);

