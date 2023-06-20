//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значение x1");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y1");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение x2");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение y2");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значение z2");
int z2 = int.Parse(Console.ReadLine());

double result_1 = Math.Pow((x2-x1),2);
double result_2 = Math.Pow((y2-y1),2);
double result_3 = Math.Pow((z2-z1),2);
double right_result = Math.Sqrt(result_1+result_2+result_3);
double final_result = Math.Round(right_result, 2);
Console.WriteLine($"Расстояние между точками = {final_result}");    