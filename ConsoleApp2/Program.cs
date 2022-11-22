namespace Prakticheskaya2
{
    internal class Program
    {
        static void Main()
        {
            int gameNumber = 0;
            do
            {


                Console.WriteLine("Выберите номер игры: ");

                Console.WriteLine("1 - 'Угадай число' \n2 - 'Таблица умножения'\n4 - Выйти из программы");
                gameNumber = Convert.ToInt32(Console.ReadLine());
                switch (gameNumber)
                {
                    case 1:
                        {
                            game1();
                            break;
                        }
                    case 2:
                        {
                            game2();
                            break;

                        }
                   

                        
                    case 4:
                        Console.WriteLine("Все работает,кроме 3");
                        break;
                }


                static void game1()
                {
                    Console.WriteLine("Угадай число");

                    Random rnd = new Random();
                    int random_chislo = rnd.Next(1, 100);
                    int chislo = 0;
                    do
                    {
                        Console.WriteLine("Введите ваше число, падаван: ");
                        chislo = Convert.ToInt32(Console.ReadLine());
                        if (chislo != random_chislo)
                        {
                            if (chislo > random_chislo)
                                Console.WriteLine("Возьми поменьше");
                            else
                                Console.WriteLine("Возьми побольше");
                        }

                    } while (random_chislo != chislo);
                    Console.WriteLine("Победа!");
                }

                static void game2()
                {
                    Console.WriteLine("Таблица умножения");
                    int[,] tablica = new int[11, 11];
                    for (int i = 1; i < tablica.GetLength(0); i++)
                    {
                        for (int j = 1; j < tablica.GetLength(1); j++)
                        {
                            tablica[i, j] = i * j;
                        }
                    }
                    for (int i = 1; i < tablica.GetLength(0); i++)
                    {
                        for (int j = 1; j < tablica.GetLength(1); j++)
                        {
                            Console.Write(tablica[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                
                
        }
    }
}
