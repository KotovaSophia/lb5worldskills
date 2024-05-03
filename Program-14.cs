class Animal
{
    public string Name,
        Food,
        Location;

    public Animal(string food, string location, string name)
    {
        Food = food;
        Location = location;
        Name = name;
    }

    public virtual void MakeNoise() => Console.WriteLine($"{Name} спит.");
    public virtual void Eat() => Console.WriteLine($"{Name} питается - {Food}.");
}

class Cat : Animal
{
    string Hostes;
    public Cat(string food, string location, string name, string hostes) : base(food, location, name)
    {
        Hostes = hostes;
    }
    public override void MakeNoise() => Console.WriteLine("Кошка спит.");
    public override void Eat() => Console.WriteLine($"Кошка питается - {Food}.");
}
class Dog : Animal
{
    string Collar;
    public Dog(string food, string location, string name, string collar) : base(food, location, name)
    {
        Collar = collar;
    }
    public override void MakeNoise() => Console.WriteLine("Собака спит.");
    public override void Eat() => Console.WriteLine($"Собака питается - {Food}.");
}


class Horse : Animal
{
    string Barn;
    public Horse(string food, string location, string name, string barn) : base(food, location, name)
    {
        Barn = barn;
    }
    public override void MakeNoise() => Console.WriteLine("Лошадь спит.");
    public override void Eat() => Console.WriteLine($"Лошадь питается - {Food}.");
}

class Veterinar
{
    public void ThreadAnimal(Animal animal) => Console.WriteLine($"На приём пришёл: {animal.Name}, который питается: {animal.Food} и обитает в {animal.Location}");
}
internal class Program
{
    private static void Main(string[] args)
    {
        Cat cat_vasya = new("Молоко", "Дом", "Василий", "Сам себе хозяин");
        Dog dog_barbos = new("Сухой корм", "Дом", "Барбос", "Нет");
        Horse horse_pumpkin = new("Морковь", "Амбар", "Тыковка", "Да");

        Veterinar veterinar = new();
        veterinar.ThreadAnimal(cat_vasya);
        veterinar.ThreadAnimal(dog_barbos);
        veterinar.ThreadAnimal(horse_pumpkin);
    }
}