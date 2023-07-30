// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int columns = int.Parse(Console.ReadLine());

        // Создаем пустой двумерный массив
        int[,] array = new int[rows, columns];
        
        // Вводим элементы для каждой ячейки массива
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Введите элементы для {i + 1}-й строки через пробел: ");
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = int.Parse(input[j]);
            }
        }

        int numColumns = array.GetLength(1);
        int[] columnSums = new int[numColumns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < numColumns; j++)
            {
                columnSums[j] += array[i, j];
            }
        }

        double[] columnAverages = new double[numColumns];
        for (int i = 0; i < numColumns; i++)
        {
            columnAverages[i] = (double)columnSums[i] / rows;
        }

        // Выводим средние арифметические каждого столбца
        for (int i = 0; i < numColumns; i++)
        {
            Console.Write($"{columnAverages[i]:0.0}; ");
        }




// array = [
//   [1, 4, 7, 2],
//   [5, 9, 2, 3],
//   [8, 4, 2, 4]
// ]

// num_columns = len(array[0])
// column_sums = [0] * num_columns

// for row in array:
//   for i in range(num_columns):
//     column_sums[i] += row[i]

// column_averages = [column_sum / len(array) for column_sum in column_sums]

// for average in column_averages:
//   print(round(average, 1), end='; ')