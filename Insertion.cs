using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao
{
    public static class InsertionAlgorithm
    {
        public static void InsertionSort(string[] arr, ref int swaps)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                string key = arr[i];
                int j = i - 1;

                // Move os elementos do arr[0..i-1] que são maiores que key para uma posição à frente de sua posição atual
                while (j >= 0 && String.Compare(arr[j], key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                    swaps++; // Contabiliza as operações de troca
                }

                arr[j + 1] = key;
            }
        }
    }
}
