/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
System.Console.WriteLine("Напишите число");
int N = Convert.ToInt32(Console.ReadLine());
int startN = 1;

while (startN <= N)
{
    if(startN % 2 ==0)
    System.Console.Write(startN + ",");
    startN ++;
}
