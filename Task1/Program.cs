// Программа, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

System.Console.WriteLine("Введи первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    System.Console.Write($"{firstNumber} больше, чем {secondNumber}");
}
if (firstNumber < secondNumber)
{
    System.Console.Write($"{secondNumber} больше, чем {firstNumber}");
}
if (firstNumber == secondNumber)
{
    System.Console.Write($"{secondNumber} равно {firstNumber}");
}