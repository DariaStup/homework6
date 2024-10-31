namespace ConsoleApp1
{
    public class Farm
    {
        public void FarmMenu()
        {
            Console.WriteLine($"Что будем делать?:\nПроведать курицу Gale - 1 \nПроведать курицу Hanna - 2\nПроведать кролика Harry - 3\nПроведать кролика Anny - 4");
            string? input1 = Console.ReadLine();
            Chicken ChickenGale = new("Gale", 0);
            Chicken ChickenJenya = new("Hanna", 0);
            Rabbit RabbitHarry = new("Harry", new Random().Next(3, 6));
            Rabbit RabbitAnny = new("Anny", new Random().Next(3, 6));

            if (input1 == "1")
            {
                ChickenGale.Doing();
            }
            else if (input1 == "2")
            {
                ChickenJenya.Doing();
            }
            else if (input1 == "3")
            {
                RabbitHarry.Doing();
            }
            else if (input1 == "4")
            {
                RabbitAnny.Doing();
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
            }
        }        

    }
}