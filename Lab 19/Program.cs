using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>
            {
              new Computer() {Code=01,Brand="Lenovo",Processor="Intel Core i5",ProcessorFrequency=2.9,RAM=8,HD=512,Memore_VC=2,Cost=423.46,Count=45 },
              new Computer() {Code=02,Brand="Acer",Processor="Intel Core i7",ProcessorFrequency=3.1,RAM=16,HD=512,Memore_VC=8,Cost=613.12,Count=13 },
              new Computer() {Code=03,Brand="Sony",Processor="AMD Ryzen 5",ProcessorFrequency=2.1,RAM=16,HD=512,Memore_VC=6,Cost=441.56,Count=7 },
              new Computer() {Code=04,Brand="Acer",Processor="Intel Core i7",ProcessorFrequency=2.6,RAM=16,HD=512,Memore_VC=4,Cost=595.76,Count=35 },
              new Computer() {Code=05,Brand="HP",Processor="Intel Core i9",ProcessorFrequency=2.4,RAM=32,HD=2048,Memore_VC=8,Cost=795.67,Count=12 },
              new Computer() {Code=06,Brand="Lenovo",Processor="AMD Ryzen 5",ProcessorFrequency=2.9,RAM=8,HD=512,Memore_VC=6,Cost=643.78,Count=31 }
            };

            Console.WriteLine("Выберите процессор: \"Intel Core i5\", \"Intel Core i7\", \"Intel Core i9\", \"AMD Ryzen 5\"");
            string s1 = Console.ReadLine();


            List<Computer> computers1 = (from c in computers
                                         where c.Processor == s1
                                         select c).ToList();
            foreach (Computer c in computers1)
            {
                Console.WriteLine($"{c.Code},{c.Brand},{c.Processor},{c.ProcessorFrequency},{c.RAM},{c.HD},{c.Memore_VC},{c.Count}");
            }
            Console.ReadKey();

            Console.WriteLine("Выберите объем оперативной памяти: \"8 Гб\", \"16 Гб\", \"32 Гб\" ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers
                           .Where(c => c.RAM >= s2).ToList();

            foreach (Computer c in computers2)
            {
                Console.WriteLine($"{c.Code},{c.Brand},{c.Processor},{c.ProcessorFrequency},{c.RAM},{c.HD},{c.Memore_VC},{c.Count}");
            }
            var computer3 = (from c in computers
                             orderby c.Cost ascending
                             select c).ToList();


            foreach (Computer c in computer3)
            {
                Console.WriteLine($"Код: {c.Code},марка компьютера: {c.Brand},тип процессора: {c.Processor}, тактовая частота: {c.ProcessorFrequency},объем оперативной памяти: {c.RAM},объем жесткого диска: {c.HD},объем памяти видеокарты: {c.Memore_VC},цена: {c.Cost}, количество:{c.Count}");
            }
            var computer4 = (from c in computers
                             orderby c.Cost descending
                             orderby c.Processor
                             select c).ToList();


            foreach (Computer c in computer4)
            {
                Console.WriteLine($"Код: {c.Code},марка компьютера: {c.Brand},тип процессора: {c.Processor}, тактовая частота: {c.ProcessorFrequency},объем оперативной памяти: {c.RAM},объем жесткого диска: {c.HD},объем памяти видеокарты: {c.Memore_VC},цена: {c.Cost}, количество:{c.Count}");
            }
            double max = computers
                    .Max(c => c.Cost);

            Console.WriteLine($"Максимальная цена компьютера составляет: {max}");
            double min = computers
                   .Min(c => c.Cost);

            Console.WriteLine($"Максимальная цена компьютера составляет: {min}");

            bool computers5 = computers.Any(c => c.Count >= 30);
            if (computers5)
            {
                Console.WriteLine("Да,есть компьютеры,колличество которых не менее 30 шт");
            }
            else
            {
                Console.WriteLine("Нет,колличество всех эеземпляров компьютеров менее 30");
            }





            Console.ReadKey();
        }
         
    }

    class Computer
    {
        public int Code { get; set; }
        public string Brand { get; set; }
        public string Processor { get; set; }
        public double ProcessorFrequency { get; set; }
        public int RAM { get; set; }
        public int HD { get; set; }
        public int Memore_VC { get; set; }
        public double Cost { get; set; }
        public int Count { get; set; }
    }

}
