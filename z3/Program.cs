//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*Console.WriteLine("Введите ваше число");
int num = int.Parse(Console.ReadLine());
int i = 1;
int result = 0;

while (i<num)
{
    result=i*i*i;
    Console.WriteLine($"Число {i}, его куб = {result}");
    i++;
} обычное решение */

//Решение методом: 

int findCubeN(int number)
{
int i = 1;
int result = 0;
while (i<=number)
{
    result=i*i*i;
    Console.WriteLine($"Число {i}, его куб = {result}");
    i++;
}
return result;
}
Console.WriteLine("Введите ваше число");
int num = int.Parse(Console.ReadLine());
int final_result = findCubeN(num);
