using ConsoleApp1;

Farm FunnyFarm = new();
FunnyFarm.AddChicken(new Chicken("Gale", new Random().Next(0, 3)));
FunnyFarm.AddChicken(new Chicken("Valya", new Random().Next(0, 3)));
FunnyFarm.AddChicken(new Chicken("Jenya", new Random().Next(0, 3)));
FunnyFarm.AddChicken(new Chicken("Hanna", new Random().Next(1, 3)));
FunnyFarm.AddRabbit(new Rabbit("Harry", new Random().Next(2, 6)));
FunnyFarm.AddRabbit(new Rabbit("Petr", new Random().Next(2, 6)));
FunnyFarm.AddRabbit(new Rabbit("Anny", new Random().Next(2, 6)));
FunnyFarm.Info();

namespace ConsoleApp1
{
}