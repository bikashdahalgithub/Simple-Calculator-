﻿using System;
Console.WriteLine("Enter the action to be performed");
Console.WriteLine("1 for Addition");
Console.WriteLine("2 for Subtraction");
Console.WriteLine("3 for Multiplictation");
Console.WriteLine("4 for Division");
Console.WriteLine("5 for Remainder After Division");
int action = int.Parse (Console.ReadLine());
int number1, number2;
Console.WriteLine("Enter  First Number:");
number1 = int.Parse (Console.ReadLine());
Console.WriteLine("Enter Second Number:");
number2 = int.Parse (Console.ReadLine());
int result = 0;
switch (action){
    case 1:{
        result = Addition(number1, number2);
        break;
    }
    default:
    Console.WriteLine("Sorry Invalid Input:");
    break;
}
Console.WriteLine("The result is {0}",result);
Console.ReadKey();
int Addition(int number1, int number2)
{
    int result = number1 + number2;
    return result;
}


