namespace Composite;

// Composite class representing a military unit (e.g., squad, platoon, company)
public class MilitaryUnit : IMilitaryUnit
{
    private List<IMilitaryUnit> members = new List<IMilitaryUnit>();

    public void AddMember(IMilitaryUnit member)
    {
        members.Add(member);
    }

    public void RemoveMember(IMilitaryUnit member)
    {
        members.Remove(member);
    }

    public void ConductOperation()
    {
        Console.WriteLine("Commanding the military unit to conduct an operation.");
        foreach (var member in members)
        {
            member.ConductOperation();
        }
    }

    public override string ToString()
    {
        string result = "MilitaryUnit(";
        foreach (var member in members)
        {
            result += member.ToString() + "+";
        }
        result = result.TrimEnd('+') + ")";
        return result;
    }
}