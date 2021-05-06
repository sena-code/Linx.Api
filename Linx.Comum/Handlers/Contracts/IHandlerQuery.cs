using Linx.Comum.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linx.Comum.Handlers.Contracts
{
    public interface IHandlerQuery<T> where T : IQuery
    {
        IQueryResult Handler(T query);
    }
}
