﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosOrdenacao
{
    public static class MergeAlgorithm
    {
        public static void MergeSort(string[] arr, ref int swaps)
        {
            if (arr.Length <= 1)
                return;

            int mid = arr.Length / 2;
            string[] leftArray = new string[mid];
            string[] rightArray = new string[arr.Length - mid];

            Array.Copy(arr, 0, leftArray, 0, mid);
            Array.Copy(arr, mid, rightArray, 0, arr.Length - mid);

            MergeSort(leftArray, ref swaps);
            MergeSort(rightArray, ref swaps);

            Merge(arr, leftArray, rightArray, ref swaps);
        }

        public static void Merge(string[] arr, string[] leftArray, string[] rightArray, ref int swaps)
        {
            int leftIndex = 0, rightIndex = 0, arrIndex = 0;

            // Enquanto houver elementos em ambas as sublistas
            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                // Compara os elementos atuais das sublistas
                if (String.Compare(leftArray[leftIndex], rightArray[rightIndex]) < 0)
                {
                    // Se o elemento da sublista esquerda for menor, copia para a lista original
                    arr[arrIndex++] = leftArray[leftIndex++];
                }
                else
                {
                    // Se o elemento da sublista direita for menor, copia para a lista original
                    arr[arrIndex++] = rightArray[rightIndex++];
                    
                    swaps++;
                }
            }

            // Copia os elementos restantes da sublista esquerda, se houver
            while (leftIndex < leftArray.Length)
            {
                arr[arrIndex++] = leftArray[leftIndex++];
            }

            // Copia os elementos restantes da sublista direita, se houver
            while (rightIndex < rightArray.Length)
            {
                arr[arrIndex++] = rightArray[rightIndex++];
            }
        }
    }
}
