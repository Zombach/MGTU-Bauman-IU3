namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class Vehicle(string registrationNumber, string make, string model)
{
    public string RegistrationNumber { get; set; } = registrationNumber;
    public string Make { get; set; } = make;
    public string Model { get; set; } = model;

    public virtual decimal CalculateCost(int hours) => hours * 10;
}
