using System;

namespace BaiTapMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bai 1: Đọc và in các phần tử trong mảng vừa nhập.

            //Console.Write("Nhap phan tu: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Phan tu thu {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Cac phan tu mong mang la:");
            //for (int i = 0;i < arr.Length;i++)
            //{
            //    Console.Write($"{arr[i]} \t");
            //}

            //bai 2: In mảng dữ liệu trên theo chiều đảo ngược.
            //Console.Write("Nhap phan tu: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Phan tu thu {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Cac phan tu trong mang la: ");
            //for (int i = arr.Length - 1;i >= 0 ; i--) 
            //{
            //    Console.Write($"{arr[i]} \t");
            //}

            //bai 3: Tìm số phần tử giống nhau trong mảng và hiển thị số lượng giống nhau ra màn hình
            //Console.Write("Nhap phan tu: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Phan tu thu {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 1;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count > 1)
            //    {
            //        Console.WriteLine("phan tu {0} xuat hien {1} lan", arr[i], count);
            //    }
            //}

            //bai 4: In các phần tử duy nhất trong mảng
            //Console.Write("Nhap phan tu: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Phan tu thu {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Cac phan tu duy nhat duoc tim thay trong mang la: \n");
            //for (int i = 0; i < n; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < i - 1; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //        }
            //    }
            //    for (int k = i + 1; k < n; k++)
            //    {
            //        if (arr[i] == arr[k])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 0)
            //    {
            //        Console.Write("{0} ", arr[i]);
            //    }
            //}


            //bai5: Chia mảng dữ liệu ban đầu thành mảng chẵn và mảng lẽ.
            //Console.Write("Nhap phan tu: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Phan tu thu {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0;i < arr.Length;i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        Console.WriteLine($"Cac phan tu mang chan la: {arr[i]}");
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        Console.WriteLine($"Cac phan tu mang le la: {arr[i]}");
            //    }
            //}

            //bai 6: Sắp xếp mảng theo thứ tự giảm dần.
            //Console.Write("Nhap phan tu: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Phan tu thu {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //Console.WriteLine("Cac phan tu giam dan: ");
            //for (int i = arr.Length - 1;i >= 0;i--)
            //{
            //    Console.Write($"{arr[i]} \t");
            //}

            //bai 7:Tìm kiếm phần tử lớn thứ hai trong mảng dữ liệu ban đầu.
            //Console.Write("Nhap phan tu: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Phan tu thu {i + 1}:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = arr[0];
            //for (int i = 1;i < arr.Length; i++)
            //{
            //    if(arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine("");
            //int secondMax = arr[0];
            //for (int i = 1;i < arr.Length ; i++)
            //{
            //    if (arr[i] > secondMax && arr[i] < max)
            //    {
            //        secondMax = arr[i];
            //    }
            //}
            //Console.WriteLine("phan tu lon thu 2: " + secondMax);

            Console.ReadKey();
        }
    }
}
