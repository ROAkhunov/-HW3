//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// // 12821 -> да

Console.WriteLine("Ввведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int nDouble=n;
int count= 0;
string result="ничего";
 while (n>10)
 {
    n=n/10;
    count++;
}
while (nDouble>10)
{
   if (nDouble/Convert.ToInt32(Math.Pow(10,count))==nDouble%10)
   {
    nDouble=nDouble%Convert.ToInt32(Math.Pow(10,count));
    nDouble=nDouble/10;
    result="yes";
    count-=2;
   } 
   else
   {
   result="no";
    nDouble=0;
   }
}
 System.Console.WriteLine(result);

