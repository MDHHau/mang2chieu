using System;
class program
{
    static void Main()
    {
        int n;

        Console.WriteLine("nhap so luong mang: ");
        n = int.Parse(Console.ReadLine());
        int[,] a = new int[n, n];
        Console.WriteLine("mang vuong co kich thuoc " + n + "x" + n + "");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("nhap phan tu thu " + i + "" + j + "=");
                int k = Convert.ToInt32(Console.ReadLine());
                a[i, j] = k;
            }
        }
        Console.WriteLine("hien thi mang: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("phan tu thu " + i + "" + j + "= " + a[i, j]);
                Console.WriteLine("====");
            }
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    if (a[i, j] % 2 != 0)
                    {
                        sum += a[i, j];

                    }
                }
            }
        }
        Console.WriteLine("tong: " + sum);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (a[i, j] < 0)
                {
                    a[i, j] = Math.Abs(a[i, j]);
                }
            }
        }
        Console.WriteLine("hien thi mang: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("phan tu thu " + i + "" + j + "= " + a[i, j]);
                Console.WriteLine("====");
            }
        }
    }
 }

    
        

    
