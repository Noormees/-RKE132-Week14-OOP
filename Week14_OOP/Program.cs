// OOP baseerub classile
// loome klassi objekti nt.WriteLine



Console.WriteLine("Name your Dog");
string myDogName = Console.ReadLine();


Dog myDog = new Dog(myDogName);          // loome Dog-classi 1 objekti - myDog
Dog neighboursDog= new Dog("Good Girl");

Console.WriteLine($"You Dog name now is {myDog.Name}");
Console.WriteLine($"My neighbours dog name is {neighboursDog.Name}");

//Console.WriteLine("Do u want to rename you Dog? (y/n)");
//char Answer = Char.Parse(Console.ReadLine());

//if (Answer = "y")
//{
//    Console.WriteLine("Please enter your Dog new Name:");
//    string rename = Console.ReadLine();
//    myDog.Rename(rename);
//}



while (myDog.LevelofHapiness != 5)  // loome tsikli, et dog haugus viis korda
{
    myDog.Bark();
}

myDog.WagTail();
Console.WriteLine($"My dog level of hapiness is: {myDog.LevelofHapiness}");

class Dog       //loome classi nimega Dog, mmillel on 2 atribuudi
{
    private string _name;       //loome kirjeldus - ON VAJA KAITSTA (publik -> private)
    private int _levelofHapiness;    //loome kirjeldus

    //construktor
    public Dog(string name) // name - kasutaja annab nime koerale
    { 
        _name = name;
        _levelofHapiness= 0;
    }

    //  GETTER

    public string Name      // teeme koodi turvalisemalt ning katttesaadava (private -> publik)
    { 
        get { return _name; }
    }

    public int LevelofHapiness      // teeme koodi turvalisemalt ning katttesaadava (private -> publik)
    {
        get { return _levelofHapiness; }
    }

    public void Rename(string newName)
    { 
        _name= newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark()  // loome koerale funktsiooni haukimiseks
    {
        Console.WriteLine("Woof-woof!");
        _levelofHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle");    
    }
}

