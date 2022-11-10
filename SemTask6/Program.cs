// Напишите программу, которая на вход принимает число и является четным, т е делится без остатка на 2
string? inputLineA = Console.ReadLine();


if (inputLineA != null) 
{
    int inputNumberA = int.Parse(inputLineA); 

int DivideA = inputNumberA % 2;
    if (DivideA == 0)
    {
        Console.WriteLine("четное");
    }
    else
    {
        Console.WriteLine("нечетное");
    }

}
