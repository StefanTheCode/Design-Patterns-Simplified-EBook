namespace Builder;

// House class representing the blueprint for the final product
public class House
{
    public int Bedrooms { get; set; }
    public bool HasGarage { get; set; }
    public List<string> Amenities { get; set; }

    public void Display()
    {
        Console.WriteLine($"Bedrooms: {Bedrooms}");
        Console.WriteLine($"Garage: {(HasGarage ? "Yes" : "No")}");
        Console.WriteLine("Amenities:");
        foreach (var amenity in Amenities)
        {
            Console.WriteLine($"- {amenity}");
        }
    }
}