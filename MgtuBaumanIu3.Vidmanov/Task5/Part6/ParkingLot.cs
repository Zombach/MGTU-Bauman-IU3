using MgtuBaumanIu3.Vidmanov.Task5.Part6.Interfaces;

namespace MgtuBaumanIu3.Vidmanov.Task5.Part6;

public class ParkingLot : IAdd
{
    private readonly List<Vehicle> _vehicles = new List<Vehicle>();

    public void Add<T>(T value) => _vehicles.Add(value as Vehicle);

    public void RemoveVehicle(string registrationNumber)
    {
        Vehicle? vehicleToRemove = _vehicles.FirstOrDefault(v => v.RegistrationNumber == registrationNumber);
        if (vehicleToRemove is not null)
        {
            _vehicles.Remove(vehicleToRemove);
        }
    }

    public void DisplayRegisteredVehicles()
    {
        Console.WriteLine("Registered Vehicles:");
        foreach (Vehicle vehicle in _vehicles)
        {
            Console.WriteLine(vehicle.ToString());
        }
    }
}