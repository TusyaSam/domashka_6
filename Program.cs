// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.Write("Введите количество будущих чисел: ");
// int count = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [count];
// int y=0;

// for (int i=0; i<count; i++)
//     {
//         Console.Write("Введите число: ");
//         int x = Convert.ToInt32(Console.ReadLine());
//         array [i]= x;
//     }

// for(int j=0;j<array.Length;j++)
//     {
//        if (array[j]>0) y=y+1;
//     }
// Console.Write($"Количество чисел больше 0:  >{y}< ");






// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int x=0;
int y=0;

if ((k1-k2)==0 || (b2-b1) ==0) Console.WriteLine("Точки пересечения нет");
else 
{
x=(b2-b1)/(k1-k2);
y=k1*x+b1;  
Console.WriteLine($"Точка пересечения с координатами ({x},{y})");
}




// int [,] array2D = new int [3,5] {{1,2,3,4,5},{2,3,4,5,6},{4,5,6,7,8}}; // двумерный массив
// int [] array1D = new int [] {1,2,3,4,5}; // одномерный массив

// for (int i=0;i<array2D.GetLength(0);i++)
// {
//     for (int j=0;i<array2D.GetLength(1);j++)
//     {
//         Console.Write($"{array2D[i,j]} ");
//     }
//      Console.WriteLine();
// }


// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// Console.Clear();
// int[] array = new int[6];
// int[] arraynew = new int [6];



// for (int i=0; i<array.Length; i++)
//     {
//        array[i]=new Random().Next(1,10);
//        Console.Write(array[i]+ " ");
//     }
// Console.WriteLine();

// for (int j=0; j<arraynew.Length; j++)
//     {
//         arraynew[j]=array[array.Length-1-j];
//         Console.Write(arraynew[j]+ " ");
//     }
       

// ИЛИ
// Console.Clear();
// int[] array = {1,2,3,4,5}; // i=0,1,2,3,4
// int temp = 0;

// for (int i=0; i<=array.Length/2; i++)                 // Length = 5
// {                                        //i=0;       i=1 ;     i=2        i=3 <=2 нет
//     temp = array[i];                     //temp=1;    temp=2;    temp=3;    temp=2
//     array[i]=array[array.Length-1-i];    //a[0]=a[4]; a[1]=a[3]  a[2]=a[2]  a[3]=
//     array[array.Length-1-i]=temp;        //a[4]=1;    a[3]=2     a[2]=3
//                                           // 5,2,3,4,1  5,4,3,2,1   5,4,3,2,1            
// } 
// for (int j=0; j<=array.Length-1; j++)
// {
//     Console.Write(array[j]+" ");
// }






// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// Console.Clear();
// Console.Write("Одна сторона A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Вторая сторона B: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Третья сторона С: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a+b>c && a+c>b && b+c>a) Console.WriteLine("Треугольник существует");
// else Console.WriteLine("Треугольник не существует");





// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Clear();
// Console.Write("Введите число Х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y;
// string result = string.Empty;

// while (x>0)     // пока от нашего значения ничего не останется будем его делить
// {
//     y=x%2;      //запоминаем остаток от деления (либо 0 либо 1)
//     x=x/2;      // делим наше значение на 2 и присваиваем ему новое значение
//     result=y.ToString()+result; // выводим в строку остатки от деления
// }
// Console.WriteLine(result);







// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 сумма последующего числа = сумме двух предыдущих чисел
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear();
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int x=0;
// int y=1;

// for (int i=1; i<n+1; i++)
// {
//     Console.Write(x+ " ");
//     int temp = x;
//     x = y;
//     y = y+temp;
// }

//ИЛИ
// Console.Clear();
// Console.Write("Введите число N: ");
// int x = Convert.ToInt32(Console.ReadLine());

// int[] fibo= new int [x];
// fibo[0]=0;
// fibo[1]=1;

// for (int i=2; i<fibo.Length; i++)
// {
//     fibo[i]=fibo[i-1]+fibo[i-2];
// }

// for (int j=0; j<fibo.Length; j++)
// {
//     Console.Write(fibo[j]+" ");
// }





// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

// Console.Clear();
// int[] array = new int[6];
// int[] arraynew = new int[6];

// for (int i=0; i<array.Length; i++)
// {
//     array[i]=new Random().Next(-9,10);
//     Console.Write(array[i]+ "  ");
    

//     arraynew[i]=array[i];
//     Console.Write($"{arraynew[i]} ");
//     Console.WriteLine(" ");
// }
