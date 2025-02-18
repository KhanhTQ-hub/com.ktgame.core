namespace com.ktgame.core
{
    public interface IFocusable : IService
    {
        void OnAppFocus(bool focus);
    }
}