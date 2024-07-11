class Animal
{
  public string Name { get; set; }
  public string Color { get; set; }
  public string Sound { get; set; }
  
  public virtual void Speak()
  {
    Console.WriteLine(Sound);
  }
}

class Dog : Animal
{
  public Dog(string name, string color)
  {
    Name = name;
    Color = color;
    Sound = "Gâu gâu";
  }

  public override void Speak()
  {
    Console.WriteLine($"{Name} có màu {Color} kêu: {Sound}");
  }
}

class Cat : Animal
{
  public Cat(string name, string color)
  {
    Name = name;
    Color = color;
    Sound = "Meo meo";
  }

  public override void Speak()
  {
    Console.WriteLine($"{Name} có màu {Color} kêu: {Sound}");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Animal dog = new Dog("Lulu", "Đen");
    Animal cat = new Cat("Kitty", "Trắng");

    dog.Speak();
    cat.Speak();
  }
}