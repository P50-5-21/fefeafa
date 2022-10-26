namespace практическая
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите программу, которую вы хотите запустить: \r\n1. Угадай число\r\n2. Таблица умножения\r\n3. Выйти из программы");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                switch (a)
                {
                    case 1:
                        Guess_Number();
                        break;


                    case 2:
                        Multiplication_Table();
                        break;
                }

                Console.WriteLine("Выберите программу, которую вы хотите запустить: \r\n1. Угадай число\r\n2. Таблица умножения\r\n3. Выйти из программы");
                a = Convert.ToInt32(Console.ReadLine());
            }
        }

        static void Guess_Number()
        {
            Console.WriteLine("Угадай число от 1 до 100");
            int b = 1;
            Random rand = new Random();
            int number = rand.Next(9);
            int Guess_Number = Convert.ToInt32(Console.ReadLine());
            while (Guess_Number != number)
            {
                if (Guess_Number < number)
                {
                    Console.WriteLine("Надо больше!");
                }
                else
                {
                    Console.WriteLine("Надо меньше!");
                }

                {
                    b++;

                    Console.WriteLine("Это не то число.");
                    Guess_Number = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (Guess_Number == number)
            {
                Console.WriteLine("Вы угадали число!");

            }
            Console.WriteLine();
        }
        static void Multiplication_Table()
        {
            int x = 2;
            Console.WriteLine();


            int i;
            int multiplication;
            for (i = 1; i <= 9; i++)
            {
                Console.WriteLine("\t");
                for (multiplication = 1; multiplication <= 9; multiplication++)
                {
                    Console.Write("\t" + i * multiplication);
                }
            }
            Console.WriteLine();
        }
    }
}