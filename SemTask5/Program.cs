/// Напишите программу, которая на вход принимает 1 число, а на выходе показывает все числа в промежутке от -N до N


string? inputLineN = Console.ReadLine();


if (inputLineN != null) 
{
    int inputNumberN = int.Parse(inputLineN); 

    int startNumber = (-1) * inputNumberN;
    
    if (inputNumberN > 0)
    {

    while(startNumber < inputNumberN)
     {
        Console.Write(startNumber+ ", ");
        startNumber = startNumber + 1;// выводит не все цифры,ту, которую ввели не выводит
     }
      Console.Write(inputNumberN);// выведет введенное число в конце
    }
  
}



