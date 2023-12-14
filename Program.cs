// Домашнее задание

// Задача 1: 
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int[] array = new int[10];
// int qaunt = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,101);
//     System.Console.Write(array[i]+" ");
//     if (array[i]>=20 && array[i]<=90)
//     {
//         qaunt++;
//     }
// }
// System.Console.WriteLine();
// System.Console.WriteLine("количество элементов массива, значения которых лежат в отрезке [20,90] - "+qaunt);


// Задача 2: 
// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] array = new int[10];
// int qaunt = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,1000);
//     System.Console.Write(array[i]+" ");
//     if (array[i]%2 == 0)
//     {
//         qaunt++;
//     }
// }
// System.Console.WriteLine();
// System.Console.WriteLine("количество чётных чисел в массиве: "+qaunt);




// Задача3: 
// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

// решение 

// System.Console.Write("Введите количество элементов в массиве: ");
// int num = Convert.ToInt32 (Console.ReadLine());
// double[] array = new double [num];

// for (int i = 0; i < array.Length; i++)
// {
//     double fract = new Random().NextDouble();
//         if (fract != 0)
//     {
//         array[i] = new Random().Next(0,100) + fract;
//         System.Console.WriteLine(Math.Round(array[i], 3));
//     }
// }

// int iMax = 0;
// int iMin = 0;
// for (int i = 1; i < array.Length; i++)
// {
//     if (array[i]>array[iMax])
//     {
//         iMax = i;
//     }
//     else if (array[i]<array[iMin])
//     {
//         iMin = i;
//     }
// }
// System.Console.WriteLine("Разница между максимальным и минимальным элементами массива " + Math.Round((array[iMax] - array[iMin]),3));


// Задача 4**(не обязательно): 
// Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.

System.Console.Write("ВВедите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
int sizeAr = 1;

if (num>0 && num<100001)
{
    while (num/10 > 0)
    {
        num = num/10;
        sizeAr++;
    }
    int[] array = new int [sizeAr];
    int[] array1 = new int [sizeAr];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num2%10;
        num2 = num2/10;
    }
    for (int i=array.Length-1; i >= 0; i--)    
    {
        array1[i] = array[i];
        System.Console.Write(array1[i]+ " ");
    }
}
else
{
    System.Console.WriteLine("Число не подходит");
}

