using GFramework.core.Commanding;

namespace GFramework.core.commanding
{
    public interface ICommandHandler<T> where T : BaseCommand
    {
        bool Execute(T Command, ICommandProcessor CommandProcessor);

    }
}
