
namespace AsysYa.Domain;

public class Provider
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Rating { get; private set; }
    public bool IsAvailable { get; private set; }
    public double Latitude { get; private set; }
    public double Longitude { get; private set; }

    public Provider(string name, decimal rating, double latitude, double longitude)
    {
        Id = Guid.NewGuid();
        Name = name;
        Rating = rating;
        Latitude = latitude;
        Longitude = longitude;
        IsAvailable = true;
    }

    public void SetBusy() => IsAvailable = false;
}