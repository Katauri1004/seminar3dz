//*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.WriteLine("Введите ваше пятизначное число");
int num = int.Parse(Console.ReadLine());

if (num>99999 || num < 9999)
{
   Console.WriteLine("Вы ввели неверные данные");
   Environment.Exit(0); 
}

int rev = 0;
int a=num;
while (num!=0)
{
    rev = (rev*10) + (num%10);
    num = num / 10;
    
} 
Console.WriteLine(rev);
if (a==rev)
{
    Console.WriteLine(" Это паллиндром");
}
else
{
    Console.WriteLine(" Это не паллиндром");
}
