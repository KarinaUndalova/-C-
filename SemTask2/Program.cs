// Написать программу, которая на вход принимает 2 числа и определяет какое из них больше а какое из них меньше
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null&&inputLineB != null) 
{
    int inputNumberA = int.Parse(inputLineA); 
    int inputNumberB = int.Parse(inputLineB); 

    if (inputNumberA > inputNumberB)
    {
        Console.WriteLine("Число " + inputNumberA + " >, чем число " + inputLineB);
    }
    else
    {
        Console.WriteLine("Число " + inputNumberB + " >, чем число " + inputLineA);
    }

}
