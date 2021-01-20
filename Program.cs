using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
        double a=16.8;
        double b=12.4;
        double result=Math.Sqrt(a*b);
      Console.WriteLine($"Результат={result}");

double A=1.4;
double B=-5.5;
double C=0.6;

double AC=A-C;
double BC=-B+C;
double sum=AC+BC;
 Console.WriteLine($"AC={AC} BC={BC} AC+BC={sum}");

double x1=-6.20, x2=2.10, y1=5.20, y2=9.80;
double x3=Math.Pow(x2-x1,2);
double y3=Math.Pow(y2-y1,2);
double mySum=Math.Sqrt(x3+y3);
Console.WriteLine($"Результат={mySum}");

int a2=41;
int x=a2/10;
int y=a2%10;
Console.WriteLine($"Результат перестановки: {y}{x}");

int N=10985;
int minute=N/60;
Console.WriteLine($"C начала суток прошло: {minute} минуты");
 
 int K=202;
 int N1=365;
 var result2 = (N1 + K - 1) % 7;
Console.WriteLine($"Номер дня недели: {result2}");

        }
       

    }
}
