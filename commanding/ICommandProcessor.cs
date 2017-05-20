using GFramework.core.Commanding;
using Microsoft.Practices.Unity;

namespace GFramework.core.commanding
{
    public interface ICommandProcessor
    {
        IUnityContainer UnityContainer { get; set; }

        bool ExecuteCommand<T>(T Command, IUnityContainer UnityContainer) where T : BaseCommand;

    }
}
