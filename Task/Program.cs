/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
*/

// 1. Задан, либо введен с клавиатуры массив из строк.

// 2. Написание метода, который проходит по массиву строк - 
//    и формирует новый массив из строк, длина которых
//    меньше либо равна 3 символа.

// 3. Написание метода печати массива.

// 4. Печать нового массива.


string [] array = new string [] {"hello", "dog", "2", "Kazan", "cat", "world"};


// проходит по массиву и формирует новый
string[] GetResultArray(string[] array)
{
    string[] resultArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[count] = array[i];
            count++;
        }

    }
    return resultArray;
}



//печатает массив на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] resultArray = GetResultArray(array);
PrintArray(resultArray);

