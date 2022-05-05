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
        
        // input
        Console.WriteLine("This program identifies the type of triangle");
        Console.WriteLine("");
        Console.WriteLine("Enter side a of the triangle.");
        sideAOfTriangle = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter side b of the triangle. ");
        sideBOfTriagle = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Enter side c of the triangle.");
        sideCOfTriangle = (Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("");

        // process
        if (sideAOfTriangle == sideBOfTriagle && sideBOfTriagle == sideCOfTriangle) 
        {
            Console.WriteLine ("The triangle is equilateral");
        } else if ((sideAOfTriangle == sideBOfTriagle) || (sideAOfTriangle == sideCOfTriangle) || (sideBOfTriagle == sideCOfTriangle)) 
        { 
            Console.WriteLine ("The triangle is isosceles"); 
        } else  
        {
            Console.WriteLine ("The triangle is scalene"); 
        }
        Console.WriteLine("\nDone.");
    }
}