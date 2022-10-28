// Created by: Youngwook
// Created on: OCT 2022
//
// This function gets area of trapzoid

using System;

class Program
{
    public static void Main(string[] args)
    {
        //this function accept user input
        double upperSide;
        double lowerSide;
        double height;
        double result;
      
        Console.WriteLine("This program gets area of trapzoid.");
        Console.WriteLine("Please enter the value of the trapzoid.\n");
        Console.Write("Enter lenghts of upper side : "); upperSide = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter length of lower side : "); lowerSide = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter length of height : "); height = Convert.ToInt32(Console.ReadLine());

        result = (upperSide + lowerSide) / 2 * height;
        
        //this function prints the result
        Console.WriteLine("Area of the trapzoid is : " + result.ToString("0.00") + ". ");
    }
}