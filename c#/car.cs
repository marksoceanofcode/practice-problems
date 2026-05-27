//Practive classes
class Car
{
  public string model;
  public string make;
  public int year;

  public Car(string modelName, string makeName, int carYear)
  {
    model = modelName;
    make = makeName;
    year = carYear;
  }
  
  static void Main(string[] args)
  {
    Car myCar = new Car("CX-50", "Mazda", 2026);
    Console.WriteLine("My new car is a " + myCar.year + " " + myCar.model + " made by " + myCar.make + " ");
    Console.WriteLine($"My new car is a {myCar.year} {myCar.model} made by {myCar.make}"); //Using the $"text {variable} here" method
  }
}