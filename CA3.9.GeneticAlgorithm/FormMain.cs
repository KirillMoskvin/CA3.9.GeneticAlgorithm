using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CA3._9.GeneticAlgorithm
{
    public partial class FormMain : Form
    {
        Genetic gen;

        const int populationCount = 20;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            gen = new Genetic((int)nudCount.Value, populationCount);
            tb_set.Text = gen.NumbersToString;
            chart.Series.Clear();
            chart.Series.Add("График");
            int iterations = 0;


            tbSoulution25.Clear();
            Chromosome chr = gen.Solution(out iterations, 25);
            if (iterations == Genetic.maxIterations)
                tbSoulution25.Text += "Решение не найдено\r\n";
            else
            {
                tbSoulution25.Text += "Найденное решение: \r\n";
                tbSoulution25.Text += chr.ToString() + "\r\n";
                tbSoulution25.Text += "Разница: " +chr.Fitness.ToString()+ "\r\n" ;
                tbSoulution25.Text += "Проделано итераций: " + iterations.ToString();
            }
            chart.Series[0].Points.AddXY(25, iterations);

            tbSolution10.Clear();
            Chromosome chr1 = gen.Solution(out iterations, 10);
            if (iterations == Genetic.maxIterations)
                tbSolution10.Text += "Решение не найдено\r\n";
            else
            {
                tbSolution10.Text += "Найденное решение: \r\n";
                tbSolution10.Text += chr1.ToString() + "\r\n";
                tbSolution10.Text += "Разница: " + chr1.Fitness.ToString() + "\r\n";
                tbSolution10.Text += "Проделано итераций: " + iterations.ToString();
            }
            chart.Series[0].Points.AddXY(10, iterations);

            tbSolution5.Clear();
            Chromosome chr2 = gen.Solution(out iterations, 5);
            if (iterations == Genetic.maxIterations)
                tbSolution5.Text += "Решение не найдено\r\n";
            else
            {
                tbSolution5.Text += "Найденное решение: \r\n";
                tbSolution5.Text += chr2.ToString()  + "\r\n";
                tbSolution5.Text += "Разница: " + chr2.Fitness.ToString() + "\r\n";
                tbSolution5.Text += "Проделано итераций: " + iterations.ToString();
            }
            chart.Series[0].Points.AddXY(5, iterations);


            chart.ChartAreas[0].AxisX.ArrowStyle = AxisArrowStyle.Triangle;
            chart.ChartAreas[0].AxisX.Crossing = 0.0;
            chart.ChartAreas[0].AxisY.Crossing = 0.0;
            chart.ChartAreas[0].AxisX.IsMarksNextToAxis = false;
            chart.ChartAreas[0].AxisY.IsMarksNextToAxis = false;

            chart.ChartAreas[0].AxisX.LineWidth = 2;
            chart.ChartAreas[0].AxisY.LineWidth = 2;
            chart.ChartAreas[0].AxisX.Title = "точность";
            chart.ChartAreas[0].AxisY.Title = "кол-во итераций";
            chart.Series[0].ChartType = SeriesChartType.RangeColumn;

        }

        string NumbersToString(ICollection<int> numbers)
        {
            string res = "";
            foreach (int num in numbers)
                res += num.ToString() + " ";
            return res;
        }

        private void buttonShowTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для N (1<= N <= 1000) сгенерировать псевдослучайные данные для задачи ниже с известным"
                + "оптимальным решением. Построить графики зависимости количества итераций генетического алгоритма, дающих решение с точностью 25%, 10%, 5%, от N\r\n"
                + "9. Задача о сумме элементов подмножества\r\n" + "Выполнил Москвин Кирилл, 3 курс 9 группа.", "Условие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
