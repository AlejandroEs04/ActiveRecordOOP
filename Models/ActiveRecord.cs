namespace TestPOO.Models;

public class ActiveRecord 
{
    private readonly string _modelName;

    public ActiveRecord(string ModelName)
    {
        _modelName = ModelName;
    }
    public void AddCar() 
    {
        Console.WriteLine("Hello World, the color is: " + _modelName);
        return;
    }
}