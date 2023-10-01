namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class Car(string registrationNumber, string make, string model) : Vehicle(registrationNumber, make, model)
{
    public override decimal CalculateCost(int hours) => hours * 15;
}