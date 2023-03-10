//                                                                 _
// Метод 1 который не принимает аргументов и ничего не возвращает   |
//                                                                  | метод void 
// Метод 2 который принимает аргументы, но ничего не возвращает    _|
//                                                              
// Метод 3 который что-то возвращает, но не принимает аргументы

// Метод 4 который принимает аргументы и возвращает для дальнейшей работы


// Метод 1
// void Method1()
// {
//     Console.WriteLine("Автор ...");
// }

// Method1();
// __________________________________________________________________________

// Метод 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст");
// ____________________________________

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg: "Текст", count: 4); // именованный аргумент (явное указание какому аргументу какое значение указать)
// ___________________________________

// Метод 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);
// _______________________________

// Метод 4

// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);
// _______________________________________________________________________

//  Цикл FOR (с встроенным счетчиком)

// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);
// _______________________________________________________________________

// Цикл в цикле
// пример вывода таблицы умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <=10 ; j++)                          // |
//     {                                                      // |   для внешнего цикла - внутренний цикл является оператором или телом метода
//         Console.WriteLine($"{i} x {j} = {i * j}");         // |
//     }                                                      // |
//     Console.WriteLine();
// }
// _______________________________________________________________________

// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

// string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace (string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text [i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text,' ', '|' );
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText,'к', 'К' );
// Console.WriteLine(newText);
// ______________________________________________________________________________

// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть неотсоритрованные элементы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);