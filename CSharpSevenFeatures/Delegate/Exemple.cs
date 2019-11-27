namespace CSharpSevenFeatures.Delegate
{
    public class Exemple
    {
        //Use event keyword with delegate type to declare an event.
        //Check event is null or not before raising an event.
        //Subscribe to events using "+=" operator. Unsubscribe it using "-=" operator.
        //Function that handles the event is called event handler.Event handler must have same signature as declared by event delegate.
        //Events can have arguments which will be passed to handler function.
        //Events can also be declared static, virtual, sealed and abstract.
        //An Interface can include event as a member.
        //Events will not be raised if there is no subscriber
        //Event handlers are invoked synchronously if there are multiple subscribers
        //The .NET framework uses an EventHandler delegate and an EventArgs base class.

        public void Main()
        {
            NumberSubscriber number = new NumberSubscriber(10000);
            number.PrintMoney();
            number.PrintNumber();
        }
    }
}
