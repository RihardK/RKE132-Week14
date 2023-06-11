
Console.WriteLine("Name YOUR dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName, 87);

Console.WriteLine("Name YOUR NEIGHBOUR'S dog:");
string nghDogName = Console.ReadLine();
Dog neighbourDog = new Dog(nghDogName, 70);

Console.WriteLine($"My dog is named {myDog.Name}");
Console.WriteLine($"My dog's 'Level of happiness': {myDog.HappyLvl}");
Console.WriteLine($"My neighbour's dog is named {neighbourDog.Name}");


myDog.Bark();
Console.WriteLine($"My dog's 'Level of happiness': {myDog.HappyLvl}");
//myDog.Rename("Matu");

while (myDog.HappyLvl <= 90)
{
    myDog.Bark();
}

myDog.TailWag();
Console.WriteLine($"My dog's 'Level of happiness': {myDog.HappyLvl}");

class Dog
{
    private string _name = "Koer";
    private int _lvlOfHappy = 0;

    public Dog(string name, int happyLvl)
    {
        _name = name;
        _lvlOfHappy = happyLvl;
    }

    public string Name
    {
        get { return _name; }
    }

    public int HappyLvl
    {
        get { return _lvlOfHappy; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Dog has been renamed to {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof!");
        _lvlOfHappy++;
    }

    public void TailWag()
    {
        Console.WriteLine("Looks like they're happy!");
    }
}