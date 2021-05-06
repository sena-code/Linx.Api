using Linx.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linx.Comum.Handlers.Contracts
{
    public interface IHandlerCommand<T> where T : ICommand
    {
        ICommandResult Handler(T command);
    }
}
