﻿// See https://aka.ms/new-console-template for more information
using System;

namespace MyProject
{
    class Program
    {
        public static void Main(string[] args) // Entry point method
        {
            // Console.WriteLine("Enter a number: ");
            // Int16 age = Convert.ToInt16(Console.ReadLine());
            // Int32 age = Int16.Parse(Console.ReadLine());
            // Console.WriteLine(age);
            // Console.WriteLine(age.GetType());

            // Console.WriteLine(str2);
            // data parsing
            // typcasting
            // sample calc

            // string str1 = "123";
            // int number1 = int.Parse(str1);
            // string str1 = "false";
            // bool booleanString = bool.Parse(str1);
            // Console.WriteLine(str1.GetType());
            // Console.WriteLine(booleanString.GetType());

            // typecasting

            // float number = 0;
            // string numberOne=number.ToString(number)
            // int number1 = Convert.ToInt32(number);
            // bool number2 = Convert.ToBoolean(number);
            // string number3 = Convert.ToString(number);

            // Console.WriteLine(number);
            // Console.WriteLine(number1);
            // Console.WriteLine(number2);
            // Console.WriteLine(number3);
            // Console.WriteLine(number.GetType());
            // Console.WriteLine(number1.GetType());
            // Console.WriteLine(number2.GetType());
            // Console.WriteLine(number3.GetType());

            // int number1 = 7;
            // int number2 = 9;
            // Console.Write("The sum of two number is: ");
            // Console.Write(number1 + number2);

            // String Methods
            // Console input

            string str = "Durgesh is a Good boy";

            // string manipString = str.ToUpper();
            // string manipString = str.ToLower();
            // string manipString = str.Replace("Good", "Bad");

            // bool manipString = str.StartsWith("durgesh"); //pascal convetion  smallCamelCaseConvetion
            // bool manipString = str.Contains("boy");
            // bool manipString = str.Contains("boy");
            // string manipString = str.Trim();
            // string manipString = str.TrimStart();
            // string manipString = str.TrimEnd();
            // string manipString = str.Insert(0, "Neeraj ");
            // int manipString = str.IndexOf("o");
            // int manipString = str.IndexOf("o");
            string manipString = str.Substring(4, 6);

            Console.WriteLine(manipString);
        }
    }
}

