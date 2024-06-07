﻿using System;


Console.Write("enter the first number: ");
decimal firstNumber = Convert.ToInt16(Console.ReadLine());
Console.Write("enter the second number:  ");
decimal secondNumber = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"Addition  {firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
Console.WriteLine($"Subtraction {firstNumber} - {secondNumber} = {firstNumber-secondNumber}");
Console.WriteLine($"Multiplication {firstNumber} * {secondNumber} = {firstNumber*secondNumber}");
Console.WriteLine($"Division {firstNumber} / {secondNumber} = {firstNumber/secondNumber}");
Console.WriteLine($"Modulus {firstNumber} % {secondNumber} = {firstNumber % secondNumber}");

Console.WriteLine($"Highest value {firstNumber} or {secondNumber} = {Math.Max(firstNumber, secondNumber)}");
Console.WriteLine($"Lowest value  {firstNumber} or {secondNumber} = {Math.Min(firstNumber, secondNumber)}");
Console.WriteLine($"Round {firstNumber} + {secondNumber} = {Math.Round(firstNumber/secondNumber)}");
