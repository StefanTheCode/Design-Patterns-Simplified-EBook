using Command.Command;

namespace Command.Invoker;

// Invoker class representing the waiter
public class Waiter
{
    private List<ICommand> orders = new List<ICommand>();

    public void PlaceOrder(ICommand order)
    {
        orders.Add(order);
    }

    public void ServeOrders()
    {
        foreach (var order in orders)
        {
            order.Execute();
        }
        orders.Clear();
    }
}