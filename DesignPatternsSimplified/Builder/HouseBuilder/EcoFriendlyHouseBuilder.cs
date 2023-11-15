namespace Builder.HouseBuilder;

// Concrete builder class for Eco-Friendly Houses
public class EcoFriendlyHouseBuilder : IHouseBuilder
{
    private House house = new House();

    public void BuildBedrooms(int bedrooms)
    {
        house.Bedrooms = bedrooms;
    }

    public void BuildGarage(bool hasGarage)
    {
        house.HasGarage = hasGarage;
    }

    public void BuildAmenities(List<string> amenities)
    {
        // Eco-friendly houses have additional green amenities
        amenities.Add("Solar panels");
        amenities.Add("Rainwater harvesting system");
        house.Amenities = amenities;
    }

    public House GetHouse()
    {
        return house;
    }
}