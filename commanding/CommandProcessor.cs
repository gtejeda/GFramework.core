using System;
using System.Transactions;
using GFramework.core.Commanding;
using GFramework.core.exceptions;
using Microsoft.Practices.Unity;

namespace GFramework.core.commanding
{
    public class CommandProcessor : ICommandProcessor
    {
        public IUnityContainer UnityContainer { get; set; }

        public bool ExecuteCommand<TCommand>(TCommand Command, IUnityContainer UnityContainer) where TCommand : BaseCommand
        {
            this.UnityContainer = UnityContainer;

            var handler = UnityContainer.Resolve<ICommandHandler<TCommand>>();
            if (handler == null)
                throw new CommandHandlerNotConfigured();

            using (var transaction = new TransactionScope(TransactionScopeOption.Required, TimeSpan.FromMinutes(5)))
            {
                var result = handler.Execute(Command, this);
                transaction.Complete();
                return result;
            }
        }

    }
}
