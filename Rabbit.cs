namespace ConsoleApp1
{
    public class Rabbit
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Rabbit(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        bool live = true;//переменная условия выполнения программы
        
        public void Doing()//метод взаимодействия с кроликом
        {
            while (live)
            {

                Console.WriteLine($"Что будем делать?:\nПокормить кролика - 1 \nНичего не делать - 2");
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
                            DoNothing();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод.");
                    live = false;
                }
                if (!live)//подводим итог, если кролик умер и выходим
                {
                    Console.WriteLine("Кролик умер...");
                    Console.WriteLine($"Мяса кроликов: {Weight} кг");
                }

            }
        }
        
        public void DoNothing()//метод ничегонеделания
        {
            Console.WriteLine("Ничего не делаем");
            live = false;
        }
        public void Feed()//метод кормления
        {
            Console.WriteLine("Введите количество зерен (г):");
            int cereal = Convert.ToInt32(Console.ReadLine());
            if (cereal < 250)
            {
                live = false;
            }
            else
            {
                Weight++;
            }
        }
        
    }

}