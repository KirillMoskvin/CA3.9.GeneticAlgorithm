using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3._9.GeneticAlgorithm
{
    /// <summary>
    /// Класс особи
    /// </summary>
    class Chromosome:IComparable
    {
        /// <summary>
        /// Гены особи(элементы, включаемые в подмножество; true - элемент включен, false - не включен)
        /// </summary>
        List<bool> genome;

        /// <summary>
        /// Генератор случайных чисел
        /// </summary>
        static Random random = new Random();

        /// <summary>
        /// Отклонение подпоследовательности от 0
        /// </summary>
        int fitness = -1;

        /// <summary>
        /// Множество целых чисел (вид особей)
        /// </summary>
        static List<int> setOfInts=null;

        /// <summary>
        /// Шанс на выживание
        /// </summary>
        double survivialChance=-1;

        /// <summary>
        /// Конструктор особи, создаваемой случайным образом
        /// </summary>
        /// <param name="Count">Количество генов (мощность исходного множества)</param>
        public Chromosome(List<int> setInts)
        {
            if (setOfInts == null)
                setOfInts = setInts;
            genome = new List<bool>(setOfInts.Count);
            for (int i = 0; i < setOfInts.Count; ++i)
                genome.Add((random.Next(2) == 0) ? false : true); //случайным образом заполняем каждый элемент
        }

        /// <summary>
        /// Конструктор особи, созданной скрещиванием двух родительских
        /// </summary>
        /// <param name="mother">1-я родительская особь</param>
        /// <param name="father">2-я родительская особь</param>
        public Chromosome(Chromosome mother, Chromosome father)
        {
            if (mother.Count != father.Count) //если типы родительских особей не соответствуют
                throw new Exception("Родительские особи должны иметь одинаковое количество хромосом!");
            genome = new List<bool>(mother.Count);
            for (int i = 0; i < genome.Count; ++i)
                genome[i] = (random.Next(2) == 0) ? mother[i] : father[i]; //случайным образом заполняем каждый элемент из материнского или 
        }

        /// <summary>
        /// Шансы на выживаемость данной особи
        /// </summary>
        /// <returns></returns>
        public int Fitness
        {
            get
            {
                if (fitness < 0)
                    fitness = CalculateFitness();
                return fitness;    
            }
            set
            {
                fitness = value;
            }
        }


        /// <summary>
        /// Рассчет шансов на выживаемость
        /// </summary>
        /// <returns></returns>
        public int CalculateFitness()
        {
            int sum=0;
            for (int i = 0; i < setOfInts.Count; ++i)
                sum += (genome[i]) ? setOfInts[i] : 0; //если элемент содержится в множестве, добваляем его в сумму, иначе- нет
            return Math.Abs(sum); //возвращаем отклонение суммы от нуля
        }

        /// <summary>
        /// Рассчет вероятности выживания данной особи
        /// </summary>
        /// <param name="sum">Сумма фитнесс-функций </param>
        /// <returns>Вероятность выживания</returns>
        public double CountSurvivialChance(int sum)
        {
            survivialChance = (sum-Fitness) / survivialChance;
            return survivialChance;
        }

        /// <summary>
        /// Переопределение вывода 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < genome.Count; i++)
                if (genome[i])
                    res += setOfInts[i].ToString() + " ";
            return res.Trim();
        }

        /// <summary>
        /// Преобразование особи в подмножество
        /// </summary>
        /// <returns>подмножество</returns>
        public List<int> ToList()
        {
            List<int> res = new List<int>();
            for (int i = 0; i < genome.Count; i++)
                if (genome[i])
                    res.Add(setOfInts[i]);
            return res;
        }

        internal void Mutate()
        {
            int mutationsCount = random.Next(0, genome.Count / 4); //количество мутации, не более четверти
            for (int i=0; i<mutationsCount; i++)
            {
                int mutatedGene = random.Next(0, genome.Count);
                genome[mutatedGene] = !(genome[mutatedGene]); //случайный ген меняется
            }
        }


        /// <summary>
        /// Реализация интерфейса IComparable
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            Chromosome other = (Chromosome)obj;
            if (other == null || other.Fitness < this.Fitness)
                return 1;
            if (other.Fitness > this.Fitness)
                return -1;
            return 0;
        }


        /// <summary>
        /// Своиство, возвращающее число хромосом
        /// </summary>
        public int Count
        {
            get { return genome.Count; }
        }

        /// <summary>
        /// Индексатор, возвращает i-й ген особи
        /// </summary>
        /// <param name="i">i</param>
        /// <returns> i-й ген</returns>
        public bool this[int i]
        { get { return genome[i]; } }

        /// <summary>
        /// Свойство, 
        /// </summary>
        public double SurvivialChance
        {
            get
            {
                return survivialChance;    
            }
        }


        
    }

}

