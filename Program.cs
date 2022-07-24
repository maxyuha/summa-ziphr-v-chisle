using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha27()
            {//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            Console.WriteLine("введите число");
            int number=Convert.ToInt32(Console.ReadLine());
             int sum=0;
             Console.Write("в числе " + number);
             while(number>0)
             {
                sum+=number%10;
                number/=10;

             } 
             Console.WriteLine( " сумма цифр равна " + sum);  
            }
            Zadacha27();
        }
        
     }
    
}