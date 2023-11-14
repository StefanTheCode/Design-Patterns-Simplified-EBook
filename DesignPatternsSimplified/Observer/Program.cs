using Observer.Observers;
using Observer.Station;

// Weather Station
WeatherStation weatherStation = new WeatherStation();

// Weather Devices (Observers)
IObserver mobileApp1 = new MobileApp("WeatherApp1");
IObserver mobileApp2 = new MobileApp("WeatherApp2");
IObserver outdoorDisplay = new OutdoorDisplay();

// Register observers with the weather station
weatherStation.AddObserver(mobileApp1);
weatherStation.AddObserver(mobileApp2);
weatherStation.AddObserver(outdoorDisplay);

// Weather station sends an update
weatherStation.SetWeatherUpdate("Sunny day with a high of 25°C");

// Remove an observer (unsubscribing)
weatherStation.RemoveObserver(mobileApp2);

// Weather station sends another update
weatherStation.SetWeatherUpdate("Partly cloudy with a chance of rain");

Console.ReadLine();