//Practice polymorphisim
class Animal
{
  public virtual void animalSound()
  {
    Console.WriteLine("Generic Animal Sound.");
  }
}

class Dog : Animal
{
  public override void animalSound(){
    Console.WriteLine("Rough rough!");
  }
}

class Cat: Animal
{
  public override void animalSound()
  {
      Console.WriteLine("Meow.");
  }
}

class Meerkat : Animal
{
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

    Animal dolphine = new Animal();
    dolphine.animalSound();
  }
}