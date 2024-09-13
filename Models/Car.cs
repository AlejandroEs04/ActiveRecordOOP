namespace TestPOO.Models;

public class Car 
{
    private readonly ActiveRecord _activeRecord;
    public Car()
    {
        _activeRecord = new ActiveRecord("Car");
    }

    public int Id { get; set;} // Public Method is avaible anywhere 
    public string Color { get; set;} = "";

    public void GetInfo()
    {
        _activeRecord.AddCar();
    }
}