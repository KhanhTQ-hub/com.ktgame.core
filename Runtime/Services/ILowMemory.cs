namespace com.ktgame.core
{
    public interface ILowMemory : IService
    {
        void OnLowMemory();
    }
}