/// Напишите программу, которая будет выдавать день недели по заданному номеру
//============================================================================
string? inputLine = Console.ReadLine();



if (inputLine != null) 
{
    int inputDayOfWeak = int.Parse(inputLine); 
    string outDayOfWeak = string.Empty;

    //3 способ:

    outDayOfWeak = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeak));

    Console.WriteLine(outDayOfWeak);

    // 1 способ:

//     string outDayOfWeak = string.Empty;//строка переменная куда положим switch
//     switch(inputDayOfWeak)
//     {
//         case 1: outDayOfWeak = "понедельник"; break;// break нужно, чтобы цикл завершился, привыполнении условия
//         case 2: outDayOfWeak = "вторник"; break;
//         case 3: outDayOfWeak = "среда"; break;
//         case 4: outDayOfWeak = "четверг"; break;
//         case 5: outDayOfWeak = "пятница"; break;
//         case 6: outDayOfWeak = "суббота"; break;
//         case 7: outDayOfWeak = "воскресенье"; break;
//         default: outDayOfWeak = "Такого дня нет"; break;
//     }
//    Console.WriteLine(outDayOfWeak);


// 2 способ:

//     string[] dayOfWeak = new string [7];
//     dayOfWeak[0]  = "Понедельник";
//     dayOfWeak[1]  = "Вторник";
//     dayOfWeak[2]  = "Среда";
//     dayOfWeak[3]  = "Четверг";
//     dayOfWeak[4]  = "Пятница";
//     dayOfWeak[5]  = "Суббота";
//     dayOfWeak[6]  = "Воскресенье";


// if(inputDayOfWeak>7||inputDayOfWeak<1) // || -  знак "или", если поставить && будет логическая ошибка, так как два условия сразу не могут работать
// // так как человек введет одно число например 9
// {
//     Console.WriteLine("Такого дня нет");
// }
// else
// {
//     Console.WriteLine(dayOfWeak[inputDayOfWeak-1]); //минус пишем потому, что пользователь обратиться к числу 1 или 7, а нумерация у нас с 0
// }
}
