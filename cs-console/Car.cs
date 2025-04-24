using System.ComponentModel;

namespace cs_console;

public class Car(string Brand, int Model)
{
    private readonly string Brand = Brand;
    private readonly int Model = Model;

    public void Drive()
    {
        Console.WriteLine("{0} - {1} Goes Vroom!!!", Brand, Model);
    }
}