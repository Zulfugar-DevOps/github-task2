﻿using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1

            string name = "Zulfugar";
            string surname = "Huseynli";
            string fullname = name + " " + surname;

            Console.WriteLine(fullname);

            // TASK 2

            string baza = "Salona yeni gelen mashinlarin sayi";

            var base1 = 14;
            var base2 = 60;
            var total = base1 + base2;

            Console.WriteLine(baza + " " + total);

            // TASK 3

            string baza2 = "Bu gun satilmish mashinlarin cemi";

            var garage1 = 128;
            var garage2 = 98;
            var totalgarage = garage1 - garage2;

            Console.WriteLine(baza2 + " " + totalgarage);

            // TASK 4

            var v1 = 7;
            var v2 = 4;
            var v3 = v1 * v2;

            Console.WriteLine("vurmanin cavabi" +" "+ v3 + " "+ "cavabin kvadrati" +" "+ v3 * v3);


            // TASK 4

            var b1 = 86;
            var b2 = 4;
            double b3 = 86 / 4.0;

            Console.WriteLine("bolmenin cavabi" + " " + b3 + " " + "cavabin kvadrati" + " " + b3 * b3);

            Console.ReadKey();  
             


        }
    }
}