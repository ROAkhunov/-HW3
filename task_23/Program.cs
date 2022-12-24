// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. -только вот 4 не может быть кубом целого числа
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int finish=Convert.ToInt32(Console.ReadLine());
for (int start = 1; start <= finish; start++)
{
  double result = Math.Pow(start,3) ;
   System.Console.Write(result+" ");
}