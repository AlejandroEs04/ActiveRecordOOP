using TestPOO.Models;
using System;

namespace TestPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new()
            {
                Color = "White"
            };

            car.GetInfo();
        }
    }
}
