namespace com.ktgame.core
{
    public interface IPausable : IService
    {
        void OnAppPause(bool pause);
    }
}