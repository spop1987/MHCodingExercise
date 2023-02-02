using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHCodingExercise
{
    class Program
    {
        static void Main()
        {
            int[] a = { 2, 3, 14, 18, 19 };
            int[] bTemp = { 1, 3, 5, 18, 27 };
            int[] b = new int[10];

            System.Array.Copy(bTemp, b, 5);

            combineArrays(a, b, 5);
            for (var i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
        }

        static void moveElements(int[] b, int k, int M)
        {
            int temp1 = 0;
            for (int i = M; i >= k ; i--)
            {
                temp1 = b[i];
                b[i + 1] = temp1;
            }
        }

        static void combineArrays(int[] a, int[] b, int M)
        {
            //int k = 0, temp = 0, j = M;

            //while (k < a.Length)
            //    b[j++] = a[k++];

            //Array.Sort(b);

            //for (int i = 0; i < b.Length; i++)
            //{
            //    for (int l = i + 1; l < b.Length; l++)
            //    {
            //        if (b[i] > b[l])
            //        {
            //            temp = b[i];
            //            b[i] = b[l];
            //            b[l] = temp;
            //        }
            //    }
            //}
            int k = 0, i = 0;
            int lastPositionWithNumber = M - 1;

            //while(k < a.Length && i < b.Length)
            //{
            //    if (b[k] < a[k] && a[k] < b[k + 1])
            //    {
            //        moveElements(b, k, lastPositionWithNumber);
            //        b[k + 1] = a[k];
            //        k++;
            //        lastPositionWithNumber++;
            //    }
            //    else if(i < b.Length - 1 && b[i] < a[k] && a[k] < b[i + 1])
            //    {
            //        moveElements(b, i, lastPositionWithNumber);
            //        b[i + 1] = a[k];
            //        k++;
            //        i++;
            //        lastPositionWithNumber++;
            //    }
            //    else if(k == a.Length - 1 && b[b.Length - 1] == 0)
            //    {
            //        b[b.Length - 1] = a[k];
            //    }
            //    else
            //    {
            //        i++;
            //    }
            //}

            while (k < a.Length && i < b.Length)
            {
                if (i < b.Length - 1 && b[i] == a[k] || b[i] < a[k] && a[k] < b[i + 1])
                {
                    moveElements(b, i, lastPositionWithNumber);
                    b[i + 1] = a[k];
                    k++;
                    lastPositionWithNumber++;
                }
                else if (k == a.Length - 1 && b[b.Length - 1] == 0)
                {
                    b[b.Length - 1] = a[k];
                }
                i++;
            }

        }
    }
} 