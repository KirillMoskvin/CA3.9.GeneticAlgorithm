using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3._9.GeneticAlgorithm
{
    class Genetic
    {
        /// <summary>
        /// Множество целых чисел, с которым мы работаем
        /// </summary>
        List<int> setOfInt;

        /// <summary>
        /// Текущая популяция особей
        /// </summary>
        List<Chromosome> population;

        /// <summary>
        /// Вероятности выживания текущего поколения
        ///  </summary>
        List<double> survivingChances;
        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        static Random rnd = new Random();

        /// <summary>
        /// Сумма значений фитнесс-функции
        /// </summary>
        int totalFitness;

        /// <summary>
        /// Возможная погрешность решения
        /// </summary>
        int accuracy;

        /// <summary>
        /// границы для генератора случайных чисел
        /// </summary>
        const int upperBound = -10000;
        const int lowerBound = 10000;

        /// <summary>
        /// Вероятность мутации
        /// </summary>
        const int MutationChance = 3;

        /// <summary>
        /// Максимальное число итераций
        /// </summary>
        const int maxIterations = 10000;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="countNums"></param>
        /// <param name="populationCount"></param>
        public Genetic(int countNums, int populationCount, int accuracyPercentage)
        {
            setOfInt = new List<int>(countNums); //Генерируем последовательность
            for (int i = 0; i < countNums; ++i)
                setOfInt.Add(rnd.Next(upperBound, lowerBound));

            population = new List<Chromosome>(populationCount);//Генерируем изначальную популяцию
            for (int i = 0; i < populationCount; i++)
                population.Add(new Chromosome(setOfInt));

            totalFitness = FitnessForAll();
            if (accuracyPercentage < 0 || accuracyPercentage > 100)
                accuracy = 0;
            else
                accuracy = countNums / 100 * accuracyPercentage; //высчитываем возможну погрешность
        }


        /// <summary>
        /// Работа алгоритма
        /// </summary>
        /// <param name="iterations"></param>
        /// <returns></returns>
        public List<int> Solution(out int iterations)
        {
            iterations = 0;

            do
            {
                population.Sort((a, b) => a.CompareTo(b)); //сортировка по возрастанию фитнесса
                if (population[0].Fitness <= accuracy) //если решение с заданнной точностью найдено
                    return population[0].ToList(); //то возвращаем его

                survivingChances = CalcualteChances(); //Определение шансов на продолжение рода
                population = GetNewGeneration(); //создаем новое поколение
                iterations++;
            } while (iterations < maxIterations); //цикл продолжаем, пока не превысили допустимое число итераций или не нашли решение
            population.Sort((a, b) => a.CompareTo(b));
            return population[0].ToList();
        }

        

        /// <summary>
        /// Рассчет фитнесс-функции для всей популяции
        /// </summary>
        /// <returns>Сумму значений фитнесс-функций</returns>
        protected int FitnessForAll()
        {
            int sum = 0;
            foreach (Chromosome chr in population)
                sum+=chr.Fitness;
            return sum;
        }

        /// <summary>
        /// Рассчет шансов на размножение каждой особи
        /// </summary>
        /// <returns></returns>
        protected List<double> CalcualteChances()
        {
            List <double> res = new List<double>(population.Count);
            res.Add(population[0].CountSurvivialChance(totalFitness));
            for (int i = 1; i < res.Count; i++)
                res[i] = res[i - 1] + population[i].CountSurvivialChance(totalFitness); //высчитываем список вероятностей потомства
            return res;
        }

        /// <summary>
        /// Создание нового поколения
        /// </summary>
        /// <returns>новое поколение</returns>
        private List<Chromosome> GetNewGeneration()
        {
            List<Chromosome> res = new List<Chromosome>(population.Count);
            for(int i = 0; i<res.Count; i++)
            {
                int firstNumber = GetIndexByNumber(rnd.NextDouble());
                int secondNumber = GetIndexByNumber(rnd.NextDouble());
                if (firstNumber == secondNumber) //если рандом выбрал двух одинаковых родителей
                    secondNumber += (secondNumber == 0) ? 1 : -1;  //то берем следующую или предыдущую особь
                Chromosome child = new Chromosome(population[firstNumber], population[secondNumber]);//создаем ген-потомка
                if (child.Fitness < population[firstNumber].Fitness && child.Fitness < population[secondNumber].Fitness) //если выживаемость потомка хуже выживаемости родителей
                    if (rnd.Next(0, 100) < MutationChance) //то с некоторой вероятностью он мутирует
                        child.Mutate();
                res[i] = child;
            }
            return res;
        }

        /// <summary>
        /// Возвращает индекс потомка, исходя из вероятности
        /// </summary>
        /// <param name="num">вероятность</param>
        /// <returns>индекс</returns>
        private int GetIndexByNumber(double num)
        {
            int i = 0;
            for (; i < survivingChances.Count && survivingChances[i] < num; i++) ; //пропускаем все элементы, значения которых меньше num
            return i;
        }
    }
}
