// Напишите программу, которая будет принимает число N, а на выходе показывает все четные числа числа от 1 до N
string? inputLineA = Console.ReadLine();
if (inputLineA != null) 
{
    int inputNumberA = int.Parse(inputLineA); 
    int inputNumberB = 1;

    while(inputNumberB < inputNumberA)
    {
        if (inputNumberB % 2 == 0)
        {
            Console.WriteLine(inputNumberB + ", ");
        }
        inputNumberB = inputNumberB + 1;
    }

    Console.WriteLine(inputNumberA);
}
