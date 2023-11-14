using Adapter;
using Adapter.IncompatibleAdapterExample;

// Create a European charger
EuropeanCharger europeanCharger = new EuropeanCharger();

// Create an adapter to make it work with the UK socket
IUKSocket ukSocketAdapter = new EUToUKAdapter(europeanCharger);

// Plug the European charger into the UK socket using the adapter
ukSocketAdapter.PlugIntoUKSocket();


//Simulation of incompatible adapter

// Create an incompatible adapter
IUKSocket incompatibleAdapter = new IncompatibleAdapter();
// Attempt to plug the European charger into the UK socket using the incompatible adapter
incompatibleAdapter.PlugIntoUKSocket();


Console.ReadLine();