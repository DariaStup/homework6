namespace ConsoleApp1
{
    public class Chicken
    {
        public string Name { get; private set; }
        public int Eggs { get; set; }

        public Chicken(string name, int eggs)
        {
            Name = name;
            Eggs = eggs;
        }
        bool live = true;//переменная условия выполнения программы
        public void Doing()//метод взаимодействия с курицей в курятнике
        {
            while (live)//выполняем действия с курицей
            {

                Console.WriteLine($"Что будем делать?:\nПокормить курицу - 1 \nЗабрать яйцо - 2\nНичего не делать - 3");
                string? input1 = Console.ReadLine();
                int MenusPoint;
                if (int.TryParse(input1, out MenusPoint))
                {
                    switch (MenusPoint)
                    {
                        case 1:
                            Feed();
                            break;
                        case 2:
                            TakeEgg();
                            break;
                        case 3:
                            DoNothing();
                            break;                        
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод.");
                    live = false;
                }
                if (!live)//подводим итог, если курица умерла и выходим из курятника
                {
                    Console.WriteLine("Курица умерла...");
                    Console.WriteLine($"Яиц: {Eggs}");
                }

            }
        }
        public void TakeEgg()//метод взятия яйца
        {
            Console.WriteLine("Забираем яйцо...");
            Eggs--;
            live = false;
        }

        public void DoNothing()//метод ничегонеделания
        {
            Console.WriteLine("Ничего не делаем");
            live = false;
        }
        public void Feed()//метод кормления курицы
        {
            Console.WriteLine("Введите количество зерен:");
            int cereal = Convert.ToInt32(Console.ReadLine());
            if (cereal < 3)
            {
                live = false;
            }
            else
            {
                Eggs++;
            }
        }

    }
}