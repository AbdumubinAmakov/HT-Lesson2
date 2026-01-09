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
// using System;
// public class MainClass
// {
//     public static void Main()
//     {
//         int n = Convert.ToInt32(Console.ReadLine());
//         int[] arr = new int[n];
//         int cnt = 1;

//         for (int i = 0; i < n; i++)
//         {
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         Array.Sort(arr);
//         for (int i = 0; i < n - 1; i++)
//         {
//             if (arr[i] != arr[i + 1])
//             {
//                 cnt++;
//             }
//         }
//         Console.Write(cnt + " ");
//     }

// }

//Task5
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int cnt = 1;
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int a = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <n; i++)
// {
//     if (arr[i] >= a)
//     {
//         cnt++;
//     }
// }
// Console.WriteLine(cnt);

//Task6
// int n = Convert.ToInt32(Console.ReadLine());
// string[] arr = new string[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Console.ReadLine();
// }
// string b = Console.ReadLine();
// bool found = false;
// for (int i = 0; i < n; i++)
// {
//     if (arr[i] == b)
//     {
//         found = true;
//         break;
//     }
// }
// if (found)
// {
//     Console.WriteLine("YES");
// }
// else
// {
//     Console.WriteLine("NO");
// }


//Task7
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// Array.Sort(arr);
// foreach (var item in arr)
// {
//     Console.Write($"{item} ");
// }

//Task8
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// Array.Sort(arr);
// for (int i = 0; i < n - 1; i++)
// {
//     if (arr[i] == arr[i + 1])
//     {
//         Console.Write($"{arr[i]} ");
//     }

// }

//Task9
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < n; i++)
// {
//     int cnt = 0;
//     for (int j = 0; j < n; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             cnt++;
//         }
//     }
//     if (cnt == 1)
//     {
//         Console.Write($"{arr[i]} ");
//     }

// }

//Task10
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = n-1; i >= 0 ; i--)
// {
//     if (arr[i] * arr[i - 1] > 0)
//     {
//         Console.WriteLine($"{arr[i]} {arr[i-1]}");
//         break;
//     }

// }

//Task11
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int max=int.MinValue;
// int min=int.MaxValue;

// for (int i = 0; i <n ; i++)
// {
//     if (max<arr[i])
//     {
//         max=arr[i];
//     }
//     if( min > arr[i])
//     {
//         min=arr[i];
//     }
// }
// Console.Write($"{max} {min}");