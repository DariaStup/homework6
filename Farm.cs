namespace ConsoleApp1
{
    public class Farm
    {
        public List<Rabbit> Rabbits;
        public List<Chicken> Chickens;
        public Farm()
        {
            Rabbits = new List<Rabbit>();
            Chickens = new List<Chicken>();
        }
        public void AddChicken(Chicken chicken)
        {
            Chickens.Add(chicken);
        }
        public void RemoveChicken(Chicken chicken)
        {
            Chickens.Remove(chicken);
        }

        public void AddRabbit(Rabbit rabbit)
        {
            Rabbits.Add(rabbit);
        }
        public void RemoveRabbit(Rabbit rabbit)
        {
            Rabbits.Remove(rabbit);
        }

        public void Info()
        {
            Console.WriteLine($"Информация о ферме: ");
            Console.WriteLine();
            int eggs = 0;
            foreach (var chicken in Chickens)
            {
                eggs += chicken.Eggs;
                Console.WriteLine($"Кура {chicken.Name} несет {chicken.Eggs} яиц.");
            }

            Console.WriteLine();
            double meat = 0;
            foreach (var rabbit in Rabbits)
            {
                meat += rabbit.Weight;
                Console.WriteLine($"Кролик {rabbit.Name} даст {rabbit.Weight} кг мяса.");
            }
        }
    }
}