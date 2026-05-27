//Practice polymorphisim
class Animal
{
  public string name;

  public Animal(string animalName = "Generic Name")
  {
    name = animalName;
  }

  public virtual void animalSound()
  {
    Console.WriteLine("Generic Animal Sound.");
  }
}

class Dog : Animal
{
  public Dog(string dogName = "Unknown dog") : base(dogName)
  {
  }
  public override void animalSound(){
    Console.WriteLine("Rough rough!");
  }
}

class Dolphin : Animal
{
  public Dolphin(string dolphineName = "Unknown dolphin") : base(dolphineName)
  {
  }
  public void swimmingSound()
  {
    Console.WriteLine("Slpoosh... splssh.");
  }
}

class Cat : Animal
{
  public Cat(string catName = "Unknown cat") : base(catName) //Pass up the cat's name to the Animal "name" variable
  {
  }
  public override void animalSound()
  {
      Console.WriteLine("Meow.");
  }
}

class Meerkat : Animal
{
  public Meerkat(string meerkatName = "Unknown meerkat") : base(meerkatName)
  {
  }

  public override void animalSound()
  {
    Console.WriteLine("Wrrr.");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Animal meerkat1 = new Meerkat();
    meerkat1.animalSound();

    Cat cat1 = new Cat("Kibbles");
    cat1.animalSound();
    Console.WriteLine(cat1.name);

    Dolphin dolphin = new Dolphin();
    dolphin.animalSound();
    dolphin.swimmingSound();
  }
}