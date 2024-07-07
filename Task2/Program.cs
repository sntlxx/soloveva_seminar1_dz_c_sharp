// который принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("THIS PROGRAM WILL HELP YOU TO FIND THE BIGGEST NUMBER");
System.Console.WriteLine("Type the first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Type the second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Type the third number");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maximum = firstNumber;
if (maximum < secondNumber)
{
    maximum = secondNumber;
}
if (maximum < thirdNumber)
{
    maximum = thirdNumber;
}
System.Console.WriteLine ($" {maximum} is the biggest number");