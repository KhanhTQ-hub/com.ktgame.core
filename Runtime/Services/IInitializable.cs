using Cysharp.Threading.Tasks;

namespace com.ktgame.core
{
    public interface IInitializable : IService
    {
        bool Initialized { get; set; }

        UniTask OnInitialize(IArchitecture architecture);
    }
}