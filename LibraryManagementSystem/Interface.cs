namespace LibrarySystem.Items
{
    public interface IReservable
    {
        void ReserveItem();
    }
    
    public interface INotifiable
    {
        void SendNotification(string message);
    }
}