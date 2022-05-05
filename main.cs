// Created by: Joanne Santhosh
// Created on: May 2022
//
// This program identifies the type of triangle

using System;

class Program
{
     public static void Main(string[] args)
    {
        // This program identifies the type of triangle
        int sideAOfTriangle;
        int sideBOfTriagle;
        int sideCOfTriangle;
        Console.WriteLine("This program identifies the type of triangle");
        Console.WriteLine("");

        Console.WriteLine("Enter side a of the triangle.");
        sideAOfTriangle = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter side b of the triangle. ");
        sideBOfTriagle = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter side c of the triangle.");
        sideCOfTriangle = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("");
        Console.WriteLine("Area is: " + (lengthOfTriangle * widthOfTriangle * heightOfTriangle / 3) + " cm³ ");

        Console.WriteLine("\nDone.");
    }
}