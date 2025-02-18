namespace com.ktgame.core
{
    public interface IDestructible : IService
    {
        bool WillDestroy { get; set; }
        void OnWillDestroy();
    }
}