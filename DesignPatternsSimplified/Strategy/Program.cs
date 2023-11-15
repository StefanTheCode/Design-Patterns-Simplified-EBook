using Strategy;
using Strategy.Strategies;

// Create a travel planner
TravelPlanner travelPlanner = new TravelPlanner();

// Plan a trip by car
travelPlanner.SetTravelStrategy(new CarTravelStrategy());
travelPlanner.PlanTravel("City A", "City B");

// Plan a trip by train
travelPlanner.SetTravelStrategy(new TrainTravelStrategy());
travelPlanner.PlanTravel("City C", "City D");

// Plan a trip by airplane
travelPlanner.SetTravelStrategy(new AirplaneTravelStrategy());
travelPlanner.PlanTravel("City E", "City F");

Console.ReadLine();