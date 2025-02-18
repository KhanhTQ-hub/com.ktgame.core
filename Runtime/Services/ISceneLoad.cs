namespace com.ktgame.core
{
    public interface ISceneLoad : IService
    {
        void OnSceneLoad(string sceneName);

        void OnSceneUnload(string sceneName);
    }
}