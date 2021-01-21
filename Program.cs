using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
//task 1        
        double a=16.8;
        double b=12.4;
        double result=Math.Sqrt(a*b);
      Console.WriteLine($"Результат={result}");
//task2
double A=1.4, B=-5.5, C=0.6;

double AC=A-C,BC=-B+C, sum=AC+BC;
 Console.WriteLine($"AC={AC} BC={BC} AC+BC={sum}");
 
//task 3
double x1=-6.20, x2=2.10, y1=5.20, y2=9.80;
double x3=Math.Pow(x2-x1,2);
double y3=Math.Pow(y2-y1,2);
double mySum=Math.Sqrt(x3+y3);
Console.WriteLine($"Результат={mySum}");

//task 4
int a2=41;
int x=a2/10;
int y=a2%10;
Console.WriteLine($"Результат перестановки: {y}{x}");

//task 5
int N=10985;
int minute=N/60;
Console.WriteLine($"C начала суток прошло: {minute} минуты");
 
 //task 6
 int K=202;
 int N1=365;
 var result2 = (N1 + K - 1) % 7;
Console.WriteLine($"Номер дня недели: {result2}");

// var balance=0;



// var text="999";

// var textError ="48456421";

// int number1=int.Parse(text);
// // int number2=Convert.toInt32(textError);

// int.TryParse(textError, out int result);
// System.Console.WriteLine(number1);
// System.Console.WriteLine(result);
// // System.Console.WriteLine(number2);


    }
}
}