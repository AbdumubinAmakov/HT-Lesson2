//Task1
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < n; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

//Task2
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// for (int i = b; i >= a; i--)
// {
//     Console.Write($"{arr[i]} ");
// }

//Task2
// using System;
// public class MainClass
// {
//     public static void Main()
//     {
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[n];

//         for (int i = 0; i < n; i++)
//         {
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         int a = Convert.ToInt32(Console.ReadLine());
//         int b = Convert.ToInt32(Console.ReadLine());
//         a--;
//         b--;
//         if (a >= 0 && b < n && a <= b)
//         {
//             for (int i = b; i >= a; i--)
//             {
//                 Console.Write(arr[i] + " ");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Индексҳо нодурустанд");
//         }
//     }
// }

//Task3
// using System;
// public class MainClass
// {
//     public static void Main()
//     {
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[n];
//         int min = int.MaxValue;

//         for (int i = 0; i < n; i++)
//         {
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         for (int i = 0; i < n; i++)
//         {
//             if (min > arr[i])
//             {
//                 min = arr[i];
//         Console.Write(arr[i]);

//             }
//         }

//     }
// }

//Task4
using System;
public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int cnt = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != arr[i + 1])
            {
                cnt++;
            }
        }
        Console.Write(cnt + " ");
    }
    
}