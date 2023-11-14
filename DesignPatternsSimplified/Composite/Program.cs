using Composite;

// Create individual soldiers
IMilitaryUnit soldier1 = new Soldier("John");
IMilitaryUnit soldier2 = new Soldier("Alice");
IMilitaryUnit soldier3 = new Soldier("Bob");

// Create a platoon and add soldiers to it
MilitaryUnit platoon = new MilitaryUnit();
platoon.AddMember(soldier1);
platoon.AddMember(soldier2);

// Create another platoon
MilitaryUnit anotherPlatoon = new MilitaryUnit();
anotherPlatoon.AddMember(soldier3);

// Create a company and add platoons to it
MilitaryUnit company = new MilitaryUnit();
company.AddMember(platoon);
company.AddMember(anotherPlatoon);

// Command the company to execute the order
company.ConductOperation();

// Print the military hierarchy
Console.WriteLine("\n\nMilitary Hierarchy: \n\n");
Console.WriteLine("Client: I get a simple component:");
Console.WriteLine($"RESULT: {soldier1}");

Console.WriteLine("\nClient: Now I've got a composite tree:");
Console.WriteLine($"RESULT: {company}");

Console.WriteLine("\nClient: I don't need to check the components' classes even when managing the tree:");
platoon.AddMember(soldier2);
Console.WriteLine($"RESULT: {company}");

Console.ReadLine();