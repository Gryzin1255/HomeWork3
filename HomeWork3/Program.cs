using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3

{
    
    struct Complex
    {
        public double im;
        public double re;
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }
        
        static void Task1()
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Console.WriteLine("Рассмотрим результат работы структуры:");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Результом операции сложения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Результом операции умножения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine("Результом операции вычитания чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
               + result.ToString());

            Console.WriteLine();

            Console.WriteLine("Рассмотрим результат работы класса:");
            ComplexLibrary.CComplex ccomplex1 = new ComplexLibrary.CComplex(1, 1);
            ComplexLibrary.CComplex ccomplex2 = new ComplexLibrary.CComplex(2, 2);
            ccomplex2.Im = 3;
            ComplexLibrary.CComplex cresult = ccomplex1.Plus(ccomplex2);
            Console.WriteLine("Результом операции сложения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                + cresult.ToString());
            cresult = ccomplex1.Multi(ccomplex2);
            Console.WriteLine("Результом операции умножения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());
            cresult = ccomplex1.Minus(ccomplex2);
            Console.WriteLine("Результом операции вычитания чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
               + cresult.ToString());

            Console.ReadKey();
        }
        static void Task2()
        {
            Console.WriteLine("Программа подсчета нечетных положительных чисел");
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            int oddnumbers = 0;//нечетные числа
            int oddnumbersum = 0;//сумаа нечетных чисел
            while (true)
            {
                int number = GetInt();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    oddnumbersum = oddnumbersum + number;
                    oddnumbers++;
                }
            }

            Console.WriteLine(Environment.NewLine + "Количество нечетных чисел: " + oddnumbers);
            Console.WriteLine(Environment.NewLine + "Сумма нечетных чисел: " + oddnumbersum);

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Костев Николай!");
            Console.WriteLine("Введите номер задачи 1, 2:");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("  ");
                    Task1();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("  ");
                    Task2();
                    break;
            }
        }
    }
}
