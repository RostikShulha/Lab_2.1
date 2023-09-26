using System;

namespace OPP_Lab2
{
    public class Number
    {
        private double a;

        public double A//присвоєння значення полю
        {
            set {  a =  value; }
        }

        public bool Correct()//перевірка числа, чи є воно натуральним

        {
            bool c = false;
            if (a > 0) c = true;
            return c;
        }

        public bool Prime()//перевірка, чи є число простим
        {
            if (a <= 1) return false;
            if (a <= 3) return true;
            else
            {
                if (a % 2 == 0 || a % 3 == 0) return false;
                else return true;
            }
        }

        public bool Palindrome()//перевірка на паліндром
        {
            int pal = Convert.ToInt32(a);
            int rec = 0;

            while (pal > 0)
            {
                int a = pal % 10;
                rec = rec * 10 + a;
                pal = pal / 10;
            }
            return rec == Convert.ToInt32(a);
        }

        public void Print()
        {
            Console.WriteLine("a = {0}", a);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;//так треба
            
            double x;
            try
            {
                Console.Write("x = "); x = double.Parse(Console.ReadLine());//Введення числа

                Number n = new Number();//створення об'єкту
                n.A = x;//присвоєння значення полю

                n.Print();//Друк

                if (n.Correct())
                {
                    if (n.Prime()) { Console.WriteLine("Число є простим"); }
                    else Console.WriteLine("Число не є простим");

                    if (n.Palindrome()) { Console.WriteLine("Число є паліндромом"); }
                    else Console.WriteLine("Число не є паліндромом");
                }
                else Console.WriteLine("Такого числа не існує");
            }
            catch { Console.WriteLine("Виникла помилка"); }//непередбачувані помилки
            Console.ReadKey();
        }
    }
}
