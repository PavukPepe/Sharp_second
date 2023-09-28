using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;



namespace Second_practice
{
    
    internal class Program
    {

        static void Ugad()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 100);
            do
            {
                Console.WriteLine("Введите число");
                int user = Convert.ToInt32(Console.ReadLine());
                if (user > n)
                {
                    Console.WriteLine("Меньше");
                }
                else if (user < n)
                {
                    Console.WriteLine("Больше");
                }
                else
                {
                    Console.WriteLine("Угадал!");
                    break;
                }
            } while (true);
        }

        static void Multiply()
        {
            int[,] strs = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    strs[i, j] = ((i + 1) * (j + 1));
                    Console.Write(strs[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }

        static void Delitel()
        {
            Console.WriteLine("Программа будет находить делители вврдимх чисел, пока не будет введен Stop");
            do
            {
                Console.WriteLine("Введите число: ");
                string s = Console.ReadLine();
                int sn;
                if (int.TryParse(s, out sn))
                {
                    for (int i = 1; i <= sn; i++)
                    {
                        if (sn % i == 0)
                            Console.Write(i + " ");
                    }
                }
                else if (s.ToLower() == "stop")
                {
                    break;
                }
                else
                    break;
            } while (true);
        }

        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("1. Угадай число\n2. Таблица умножения\n3. Вывод делителей числа\n4. Выход");

                int m = Convert.ToInt32(Console.ReadLine());

                switch (m) 
                {
                    case 1:
                        Ugad();
                        break;
                    case 2:
                        Multiply();
                        break;
                    case 3:
                        Delitel();
                        break;
                    
                }

                if (m == 4){
                    break;
                }
            }
            while (true);
        }
    }
}