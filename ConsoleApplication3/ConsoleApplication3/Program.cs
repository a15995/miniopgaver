﻿using System;
using System.Diagnostics;

namespace Hello.World
{
    public class HelloWorld
    {
        public static void Main()
        {
            //Opgave1();
            //Opgave2();
            //Opgave3();
            //Opgave4();
            //Opgave5();
            //Opgave6();
            //Opgave7();
            //Opgave8();
            //Opgave9();
            //Opgave10();
            Opgave11();
        }
        public static void Opgave1()
        {
            //Her er opgave 1
            Debug.WriteLine("Hello");
            Debug.WriteLine("Søren Larsen");
        }
        public static void Opgave2()
        {
            //her er opgave 2
            int x = 12 + 13;
            Debug.WriteLine(x);
        }
        public static void Opgave3()
        {
            //her er opgave 3
            double a = 24;
            double b = 5;
            double x = a / b;
            Debug.WriteLine(x);
        }
        public static void Opgave4()
        {
            //her er opgave 4
            int a = -1 + 3 * 5;
            int b = (24 + 5) % 7;
            int c = 15 + -4 * 6 / 11;
            int d = 2 + 10 / 6 * 1 - 7 % 2;
            Debug.WriteLine(a + " " + b + " " + c + " " + d);
        }
        public static void Opgave5()
        {
            Console.WriteLine("Indtast første tal: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast andet tal: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a * b);
            Console.ReadKey();
        }
        public static void Opgave6()
        {
            Console.WriteLine("Indtast første tal: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast andet tal: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast tredje tal: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a * b * c);
            Console.ReadKey();
        }
        public static void Opgave7()
        {
            Console.WriteLine("Indtast første tal: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast andet tal: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            Console.WriteLine(a + " x " + b + " = " + (a * b));
            Console.WriteLine(a + " / " + b + " = " + (a / b));
            Console.WriteLine(a + " mod " + b + " = " + (a % b));
            Console.ReadKey();
        }
        public static void Opgave8()
        {
            Console.WriteLine("Indtast tal: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("5 * " + i + " = " + (5 * i));
            }
            Console.ReadKey();
        }
        public static void Opgave9()
        {
            Console.WriteLine("Indtast første tal: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast andet tal: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast tredje tal: ");
            double c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast tredje tal: ");
            double d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a + b + c + d) / 4);
            Console.ReadKey();
        }
        public static void Opgave10()
        {
            Console.WriteLine("Indtast første tal: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast andet tal: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast tredje tal: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a + b) * c);
            Console.WriteLine(a * c + b - c);
            Console.ReadKey();
        }
        public static void Opgave11()
        {
            Console.WriteLine("Hvad er din alder? ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Du ser yngre ud end " + a + "!");
            Console.ReadKey();
        }
    }
}