// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int i=0;
int[] a= new int[3];
int[] b= new int[3];
Console.WriteLine("Введите координаты первой точки");

while (i<a.Length)
{
    a[i]=Convert.ToInt32(Console.ReadLine());
    i++;
} 
Console.WriteLine("Введите координаты второй точки");
i=0;
while (i<b.Length)
{
    b[i]=Convert.ToInt32(Console.ReadLine());
    i++;
} 
double dif1=Math.Pow(b[0]-a[0],2);
double dif2=Math.Pow(b[1]-a[1],2);
double dif3=Math.Pow(b[2]-a[2],2);
double distance=Math.Round(Math.Sqrt(dif1+dif2+dif3),2);
Console.WriteLine($"Расстояние между точками равно {distance}");