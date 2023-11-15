namespace Builder.HouseBuilder;

// HouseBuilder interface defining methods for configuring the house
public interface IHouseBuilder
{
    void BuildBedrooms(int bedrooms);
    void BuildGarage(bool hasGarage);
    void BuildAmenities(List<string> amenities);
    House GetHouse();
}