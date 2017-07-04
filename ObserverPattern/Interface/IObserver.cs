namespace ObserverPattern.Interface
{
    public interface IObserver
    {
        void Update(bool current, string status);
    }
}
