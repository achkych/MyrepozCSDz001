// seminar1
// zadacha 1 Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
  Console.WriteLine("Yes!");  
}
else
{
  Console.WriteLine("No!");  
}
*/

//zadacha2 Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/*Console.Write("Input in number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = -number;

while(current <= number)
{
   Console.Write(current + " ");
   current = current + 1; // current += 1; current ++;
}
*/

//32465
//MyrepozCSDz001
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*Console.Write("Input a first number: ");
  int a = Convert.ToInt32(Console.ReadLine());

  Console.Write("Input a second number: ");
  int b = Convert.ToInt32(Console.ReadLine());

  if (a > b)
  {
    Console.WriteLine("First number" +  "=" + a + "-Bolshe chem vtoroe" + "=" + b);
  }
  else
  {
    Console.WriteLine("Vtoroe chislo" + "=" + b + "-Bolshe chem pervoe" + "=" + a);
  }
  */

//2 sposob(universalnee):
/*Console.Write("Input a first number: ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a second number: ");
 int b = Convert.ToInt32(Console.ReadLine());

 int max = 0;
 int min = 0;
 if(a == b)
 {
  Console.WriteLine("Numbers equal!");  
 }
 else 
 if (a < b)
 {
  min = a; 
  max = b;
  Console.WriteLine("a - this min! and min=" + min);
  Console.Write("b - this max! and max="); Console.WriteLine(max);
 }

 else
 {
  min = b; 
  max = a;
  Console.Write("a - this max! and max=");  Console.WriteLine(max);
  Console.Write("b - this min! and min="); Console.WriteLine(min);  
 }
 */
 //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*Console.WriteLine("Input 3 number: ");
  int num1 = Convert.ToInt32(Console.ReadLine());
  int num2 = Convert.ToInt32(Console.ReadLine());
  int num3 = Convert.ToInt32(Console.ReadLine());

  int max = num1;

  if (num2 > max)
  {
    max = num2;
  }

  if (num3 > max)
  {
    max = num3;
  }

   Console.WriteLine("Max from input = " + max);
*/
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("Input number:");
  int num = Convert.ToInt32(Console.ReadLine());

  if (num % 2 == 0)
  {
    Console.WriteLine("Number " + num + " is: honest(chetnyi)");
  }
  else
  {
    Console.WriteLine("Number " + num + " is: odd(nechetnyi)");
  }
  */
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//ne smog
 
/* bool noh = true;
Console.Write("Input in number: ");
  int num = Convert.ToInt32(Console.ReadLine());
  int current = 1;

  while (current <= num)
  {
      if (current % 2 == 0)
      {
        Console.Write(current + " ");
        noh = false;
      }
      current++;
  }

  if (noh)
  {
    Console.WriteLine("No honest(chetnyh) number from 1 to N");
  }
  */
  // Gotovo!