using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao
{
    public static class BubbleAlgorithm
    {
        public static void BubbleSort(string[] arr, ref int swaps)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (String.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        // Troca os elementos se estiverem fora de ordem
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swaps++; // Contabiliza as operações de troca
                    }
                }
            }
        }

    }
}
