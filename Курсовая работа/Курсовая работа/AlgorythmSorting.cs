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
