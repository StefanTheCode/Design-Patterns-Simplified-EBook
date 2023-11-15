namespace Builder.HouseBuilder;

// Concrete builder class for Luxury Houses
public class LuxuryHouseBuilder : IHouseBuilder
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
        house.Amenities = amenities;
    }

    public House GetHouse()
    {
        return house;
    }
}