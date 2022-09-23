// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число ");
int num=Convert.ToInt32(Console.ReadLine());

for (int count=1; count<=num; count++)
{
    int cub=Convert.ToInt32(Math.Pow(count,3));
    if (count<num)
  {
    Console.Write($"{cub}, ");
  }  
  else Console.Write($"{cub}.");
    
}
