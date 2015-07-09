using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggetMass
{
    public class JaggetSort
    {
       public static void SortMax(int [][]a)
       {
           int[] temp = new int[a.Length];
           for (int i=0;i<a.Length;i++)
           {
               int max = a[i][0];
               for (int j=0;j<a[i].Length;j++)
               {
                   if (a[i][j] > max)
                       max = a[i][j];
               }
               temp[i] = max;
           }
           for (int i=0;i<temp.Length;i++)
               for (int j=0;j<temp.Length;j++)
               {
                   if ((j + 1) != temp.Length)
                   if (temp[j] > temp[j + 1])
                   {
                       int temp1 = temp[j];
                       temp[j] = temp[j + 1];
                       temp[j + 1] = temp1;
                       int[] temp2= a[j];
                       a[j] = a[j + 1];
                       a[j + 1] = temp2;
                   }
               }
       }

       public static void SortMin(int[][] a)
       {
           int[] temp = new int[a.Length];
           for (int i = 0; i < a.Length; i++)
           {
               int min = a[i][0];
               for (int j = 0; j < a[i].Length; j++)
               {
                   if (a[i][j] < min)
                       min = a[i][j];
               }
               temp[i] = min;
           }
           for (int i = 0; i < temp.Length; i++)
               for (int j = 0; j < temp.Length; j++)
               {
                   if ((j + 1) != temp.Length)
                       if (temp[j] > temp[j + 1])
                       {
                           int temp1 = temp[j];
                           temp[j] = temp[j + 1];
                           temp[j + 1] = temp1;
                           int[] temp2 = a[j];
                           a[j] = a[j + 1];
                           a[j + 1] = temp2;
                       }
               }
       }

       public static void SortSumm(int[][] a)
       {
           int[] temp = new int[a.Length];
           for (int i = 0; i < a.Length; i++)
           {
               int summ = 0;
               for (int j = 0; j < a[i].Length; j++)
               {
                   summ += a[i][j];
               }
               temp[i] = summ;
           }
           for (int i = 0; i < temp.Length; i++)
               for (int j = 0; j < temp.Length; j++)
               {
                   if ((j + 1) != temp.Length)
                       if (temp[j] > temp[j + 1])
                       {
                           int temp1 = temp[j];
                           temp[j] = temp[j + 1];
                           temp[j + 1] = temp1;
                           int[] temp2 = a[j];
                           a[j] = a[j + 1];
                           a[j + 1] = temp2;
                       }
               }
       }

        
    }
}
