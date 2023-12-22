// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// void printNumbers(int firstNum, int secondNum)
// {
//     Console.Write(firstNum+" ");
//     if (firstNum == secondNum)
//         return;
//     printNumbers(firstNum+1, secondNum);
// }
// printNumbers(firstNumber, secondNumber);

//--------------------------------------------------------------------------------------------------------------------------------

// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Ackermann(int n, int m)
{
    if (n == 0)
        return (m+1);
    else if (m == 0)
        return Ackermann(n-1,1);
    else
        return Ackermann(n-1,Ackermann(n,m-1));
}
System.Console.WriteLine(Ackermann(firstNumber,secondNumber));

//--------------------------------------------------------------------------------------------------------------------------------

// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

// int [] array = new int [8];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0,10);
//     Console.Write(array[i]+" ");
// }

// void printReverseArray(int[] arr, int index)
// {
//     Console.Write(arr[index]+" ");
//     if (index == 0)
//         return;
//     printReverseArray(arr, index-1);
// }

// Console.WriteLine();
// printReverseArray(array, array.Length-1);