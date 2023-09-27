class Program
{
    static void Main(string[] args)
    {
        Vga vga1 = new Nvidia();
        Vga vga2 = new amd();
        Processor pros1 = new CoreI5();
        Processor pros2 = new Ryzen();
        Processor pros3 = new CoreI7();
        Laptop laptop1 = new Vivobook(vga1, pros1);
        Laptop laptop2 = new IdeaPad(vga2, pros2);
        Predator predator = new Predator(vga2, pros3);

        Console.WriteLine("Nomor 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine("\nNomor 2");
        laptop1.Ngoding();

        Console.WriteLine("\nNomor 3");
        Console.WriteLine($"Laptop 1 memiliki VGA merk {laptop1.Vga.merk}," +
            $" processor merk {laptop1.Processor.merk}, dan processor tipe" +
            $" {laptop1.Processor.tipe}");

        Console.WriteLine("\nNomor 4");
        predator.BermainGame();

        Console.WriteLine("\nNomor 5");
        ACER acer = predator;
        acer.BermainGame();
    }

}



class Vga
{
    public string merk;
    public Vga(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia() : base("Nvidia")
    { }
}

class amd : Vga
{
    public amd() : base("AMD")
    { }
}

class Processor
{
    public string merk;
    public string tipe;

    public Processor(string merk, string tipe)
    {
        this.merk = merk;
        this.tipe = tipe;
    }
}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    { }
}

class CoreI3 : Intel
{
    public CoreI3() : base("Core i3")
    { }
}

class CoreI5 : Intel
{
    public CoreI5() : base("Core i5")
    { }
}

class CoreI7 : Intel
{
    public CoreI7() : base("Core i5")
    { }
}


class AMD : Processor
{
    public AMD(string tipe) : base("AMD", tipe)
    { }
}

class Ryzen : AMD
{
    public Ryzen() : base("RAYZEN")
    { }
}

class Athlon : AMD
{
    public Athlon() : base("ATHLON")
    { }
}

class Laptop
{
    public string Merk;
    public string Tipe;
    public Vga Vga;
    public Processor Processor;

    public Laptop(string merk, string tipe, Vga vga, Processor processor)
    {
        this.Merk = merk;
        this.Tipe = tipe;
        this.Vga = vga;
        this.Processor = processor;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS(string tipe, Vga Vga, Processor processor) : base("ASUS", tipe, Vga, processor)
    { }
}

class ROG : ASUS
{
    public ROG(Vga Vga, Processor processor) : base("ROG", Vga, processor)
    { }
}

class Vivobook : ASUS
{
    public Vivobook(Vga Vga, Processor processor) : base("Vivobook", Vga, processor)
    { }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER(string tipe, Vga Vga, Processor processor) : base("ACER", tipe, Vga, processor)
    { }
}

class Swift : ACER
{
    public Swift(Vga Vga, Processor processor) : base("Swift", Vga, processor)
    { }
}

class Predator : ACER
{
    public Predator(Vga Vga, Processor processor) : base("Predator", Vga, processor)
    { }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string tipe, Vga Vga, Processor processor) : base("Lenovo", tipe, Vga, processor)
    { }
}

class IdeaPad : Lenovo
{
    public IdeaPad(Vga Vga, Processor processor) : base("IdeaPad", Vga, processor)
    { }
}

class Legion : Lenovo
{
    public Legion(Vga Vga, Processor processor) : base("Legion", Vga, processor)
    { }
}