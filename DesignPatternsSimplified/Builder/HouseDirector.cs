using Builder.HouseBuilder;

namespace Builder;

// Director class to facilitate the construction process
public class HouseDirector
{
    public void Construct(IHouseBuilder builder, int bedrooms, bool hasGarage, List<string> amenities)
    {
        builder.BuildBedrooms(bedrooms);
        builder.BuildGarage(hasGarage);
        builder.BuildAmenities(amenities);
    }
}