// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int count = 1;
int div = 0;
while (count < number)
{
    div = count % 2;

    if (div == 0)
     {Console.Write(count + ", ");
        count = count + 1;
     }
    else 
    {
        count = count + 1;
    }
     
}
div = count % 2;
if (div == 0)
Console.Write(count);
else
Console.Write (" ");