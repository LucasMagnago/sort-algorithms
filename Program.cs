// Seusing System;
using System.Diagnostics;

namespace AlgoritmosOrdenacao
{
    class Program
    {
        static void Main()
        {
            var data = File.ReadAllText(@"../../../Palavras em Portugues.txt");

            string[] array = data.Split('\n').Take(data.Length).ToArray();

            //for (int i = 0; i < 600; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            var result = MeasureTimeAndSwaps(array);
            Console.WriteLine($"Tempo de execução: {result.Item1} segundos");
            Console.WriteLine($"Quantidade de operações: {result.Item2}");

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Array ordenado: ");
            //for (int i = 0; i < 600; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
        }

        public static Tuple<double, int> MeasureTimeAndSwaps(string[] arr)
        {
            int swaps = 0;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            //MergeAlgorithm.MergeSort(arr, ref swaps);
            BubbleAlgorithm.BubbleSort(arr, ref swaps);
            //InsertionAlgorithm.InsertionSort(arr, ref swaps);
            stopwatch.Stop();

            double executionTime = stopwatch.Elapsed.TotalSeconds;

            return Tuple.Create(executionTime, swaps);
        }
    }
}