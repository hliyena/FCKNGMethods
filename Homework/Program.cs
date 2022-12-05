// // Задача 41: Пользователь вводит с клавиатуры M чисел. 
// // Посчитайте, сколько чисел строго больше 0 ввёл пользователь.



// Console.Write("Введите числа через пробел: ");

// // Каюсь! Нашел следующие три строчки здесь:
// // https://ru.stackoverflow.com/questions/451166/Конвертация-массива-string-в-массив-int-c-одной-строкой-кода
// // ибо уже ничего не смог придумать из изученного, так как это пока овер сложно 

// int[] array = Console.ReadLine().Split(' ').
// Where(A => !string.IsNullOrWhiteSpace(A)).
// Select (A => int.Parse(A)).ToArray();

// int Num(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }
// Console.WriteLine(Num(array));




// // Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов
// // (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив,
// // но отсортированный по возрастанию(от меньшего числа к большему).


// Console.WriteLine("Введите числа через запятую");
// string[] num = Console.ReadLine().Split(new char[] { ',' });
// int[] intArray = new int[num.Length];
//     for (int i = 0; i < num.Length; i++)
//     {
//     intArray[i] = int.Parse(num[i]);
//     }
//     int indx;
//     for (int i = 0; i < intArray.Length; i++)
//     {
//     indx = i;
//     for (int j = i; j < intArray.Length; j++)
//     {
//         if (intArray[j] < intArray[indx])
//         {
//         indx = j;
//         }
//     }
//         if (intArray[indx] == intArray[i])
//         continue;
                
// int A = intArray[i]; 
// intArray[i] = intArray[indx];
// intArray[indx] = A;
// }
// Console.WriteLine("Отсортированный по возрастанию массив:");
//     foreach (int B in intArray)
//     {
//         Console.Write($"{B} ");
//     }
