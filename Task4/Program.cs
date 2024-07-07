// которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("1 "); 

for(int i = 2; i < number; i += 2) 
{
 Console.Write(i + " ");
}

if (number != 1) 
{
 Console.Write(number);
}