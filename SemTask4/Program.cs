﻿// Напишите программу. которая принимает на вход 3 числа, а выводит максимальное

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null&&inputLineB != null&&inputLineC != null ) 
{
    int inputNumberA = int.Parse(inputLineA); 
    int inputNumberB = int.Parse(inputLineB); 
    int inputNumberC = int.Parse(inputLineC); 

    if (inputNumberA > inputNumberB)
    {
        if (inputNumberA > inputNumberC)
        {
            Console.WriteLine("максимальное число " + inputNumberA);
        }
        else
        {
            Console.WriteLine("максимальное число " + inputNumberC);
        }
    }
    else if(inputNumberB > inputNumberC)
    {

        Console.WriteLine("максимальное число " + inputNumberB);
    }
    else
    {
        Console.WriteLine("максимальное число " + inputNumberC);
    }
}

    
   


