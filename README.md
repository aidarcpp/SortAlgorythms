Оглавление
Введение	4
1.	Постановка задачи	5
2.	Основные сведения	6
3.	Решение	9
4.	Блок-схема	11
5.	Исходный код	12
6.	Результаты	15
Заключение	16
Список литературы	17

Введение
	Сортировка данных является одной из важнейших задач в информатике и компьютерных науках. В зависимости от специфики задачи, объема данных и требуемой производительности применяются различные алгоритмы сортировки. Среди множества существующих алгоритмов особенно выделяются сортировка выбором, сортировка пирамидальным деревом (или пирамидальная сортировка), сортировка слиянием и сортировка вставками. Каждому из этих алгоритмов присущи свои уникальные подходы и методы, обеспечивающие определенные преимущества и недостатки в различных ситуациях.
1.	Постановка задачи
Необходимо разработать программу реализующее различные методы сортировки массивов данных. Программа должна включать в себя следующие алгоритмы сортировки: сортировка выбором (Selection Sort), сортировка пирамидальным деревом (Heapsort), сортировка слиянием (Merge Sort) и сортировка вставками (Insertion Sort). Программа должна позволять пользователю выбирать один из предложенных методов сортировки, выполнять сортировку массива и визуализировать результаты работы каждого алгоритма.
2.	Основные сведения
Рассмотрим основные сведения о четырех распространенных алгоритмах сортировки: сортировка выбором, сортировка пирамидальным деревом, сортировка слиянием и сортировка вставками.
Сортировка выбором (Selection Sort)
Принцип работы: Сортировка выбором заключается в последовательном выборе наименьшего элемента из несортированной части массива и его перемещении в начало этой части.
 
Рис.1. Пример сортировки выбором
Сортировка пирамидальным деревом (Heapsort)
Принцип работы: Heapsort использует структуру данных, называемую кучей (heap). Сначала создается максимальная куча из массива, затем элементы извлекаются из кучи и помещаются в конец массива.
 
Рис.2. Пример сортировки пирамидальным деревом
Сортировка слиянием (Merge Sort)
Принцип работы: Merge Sort основан на принципе «разделяй и властвуй». Массив рекурсивно делится на две части, каждая часть сортируется отдельно, и затем отсортированные части объединяются.
 
Рис.3. Пример сортировки слиянием
Сортировка вставками (Insertion Sort)
Принцип работы: Insertion Sort вставляет каждый элемент в свою правильную позицию в уже отсортированной части массива, перемещая элементы при необходимости.
 
Рис.4. Пример сортировки вставками
3.	Решение
Класс AlgorythmSorting.cs
Этот класс представляет основной интерфейс пользователя. Он содержит методы для обработки событий, таких как нажатие кнопки сортировки.
Методы:
btnSort_Click(object sender, EventArgs e): Обработчик события нажатия кнопки сортировки. Этот метод выполняет следующие действия:
Считывает введенный массив из текстового поля txtInputArray.
Выбирает алгоритм сортировки из выпадающего списка cmbSort.
Запускает таймер для измерения времени выполнения сортировки.
Вызывает соответствующий метод сортировки из класса Sort.
Останавливает таймер и выводит отсортированный массив и время выполнения в соответствующие текстовые поля.
Класс Sort.cs
Этот класс содержит реализации различных алгоритмов сортировки: сортировки выбором, вставкой, слиянием и пирамидальной сортировки.
Методы:
SelectionSort(int[] array): Реализует сортировку выбором. Последовательно выбирает наименьший элемент из неотсортированной части массива и меняет его местами с первым элементом неотсортированной части.
InsertionSort(int[] array): Реализует сортировку вставкой. Проходит по массиву и вставляет каждый элемент в его правильное место в отсортированной части массива.
MergeSort(int[] array): Реализует сортировку слиянием. Рекурсивно делит массив на две части, сортирует каждую часть и затем сливает их в один отсортированный массив.
HeapSort(int[] array): Реализует пирамидальную сортировку. Строит бинарную кучу из массива и затем извлекает максимальный элемент, перемещая его в конец массива.
4.	Блок-схема
 
5.	Исходный код
AlgorythmSorting.cs
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public partial class AlgorythmSorting : Form
    {
        public AlgorythmSorting()
        {
            InitializeComponent();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                var array = txtInputArray.Text.Split(',').Select(int.Parse).ToArray();

                // Выбор алгоритма сортировки
                var selectedAlgorithm = cmbSortingAlgorithm.SelectedItem.ToString();
                var stopwatch = new Stopwatch();
                stopwatch.Start();

                switch (selectedAlgorithm)
                {
                    case "Сортировка выбором":
                        Sort.SelectionSort(array);
                        break;
                    case "Сортировка вставкой":
                        Sort.InsertionSort(array);
                        break;
                    case "Сортировка слиянием":
                        array = Sort.MergeSort(array);
                        break;
                    case "Сортировка пирамидой":
                        Sort.HeapSort(array);
                        break;
                }
                stopwatch.Stop();

                // Вывод отсортированного массива и времени сортировки
                txtSortedArray.Text = string.Join(",", array);
                lblElapsedTime.Text = $"Время выполнения: {stopwatch.Elapsed.TotalMilliseconds} мс";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

Sort.cs
using System;
using System.Linq;
using System.Windows.Forms;

namespace Курсовая_работа
{
    public static class Sort
    {
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                    array[j + 1] = current;
            }
        }



        public static int[] MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return array;

            int mid = array.Length / 2;
            int[] left = array.Take(mid).ToArray();
            int[] right = array.Skip(mid).ToArray();

            return Merge(MergeSort(left), MergeSort(right));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] < right[j])
                    result[k++] = left[i++];
                else
                    result[k++] = right[j++];
            }

            while (i < left.Length)
                result[k++] = left[i++];

            while (j < right.Length)
                result[k++] = right[j++];

            return result;
        }

        public static void HeapSort(int[] array)
        {
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(array, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && array[left] > array[largest])
                largest = left;

            if (right < n && array[right] > array[largest])
                largest = right;

            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;

                Heapify(array, n, largest);
            }
        }
    }
}
6.	Результаты
 
 
Заключение
При выполнении данной курсовой работы была разработана программа на языке C# для сортировки массивов целых чисел с использованием различных алгоритмов сортировки. Программа позволяет пользователю вводить массив чисел, выбирать алгоритм сортировки и получать отсортированный массив вместе с информацией о времени выполнения сортировки.
Список литературы
Алгоритмы сортировки [В Интернете] // Хекслет. - 08 06 2024 г.. - https://ru.hexlet.io/courses/basic-algorithms/lessons/sorting/theory_unit.
Сортировка вставками [В Интернете] // Фоксфорд. - 08 06 2024 г.. - https://foxford.ru/wiki/informatika/sortirovka-vstavkami?utm_referrer=https%3A%2F%2Fwww.google.com%2F.
Сортировка выбором [В Интернете] / авт. Куликовская Н М и Лахтина Н Ю // Habr. - 08 06 2024 г.. - https://habr.com/ru/articles/422085/.
Сортировка пирамидой [В Интернете] / авт. Курсы // Habr. - 18 04 2024 г.. - https://habr.com/ru/companies/otus/articles/460087/.

