using Command.Receiver;

namespace Command.Command;

// Concrete command class representing a specific order
public class OrderCommand : ICommand
{
    private KitchenStaff kitchenStaff;
    private string dishName;

    public OrderCommand(KitchenStaff kitchen, string dish)
    {
        kitchenStaff = kitchen;
        dishName = dish;
    }

    public void Execute()
    {
        kitchenStaff.PrepareDish(dishName);
    }
}