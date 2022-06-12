// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input first number: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA > numB)
{
    Console.Write("First number is more, and second number is less  ");
}
else 
    Console.WriteLine("Second number is more, and first number is less   ");
    
  // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

  Console.WriteLine("Input first number: ");
  int num1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input second number: ");
  int num2 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input third number: ");
  int num3 = Convert. ToInt32(Console.ReadLine());
  int max = num1;
  if (num1 > num2)
  {
    Console.Write("First is maximum  ");
  }
  else 
       if (num2 > num3)
   {    
       Console.Write("Second is maximum  ");
   }   
    else
        if (num3 > num1)
    {
        Console.Write("Third is maximum  ");
    } 

    