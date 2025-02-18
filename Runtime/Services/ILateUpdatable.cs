namespace com.ktgame.core
{
    public interface ILateUpdatable : IService
    {
        void OnLateUpdate();
    }
}