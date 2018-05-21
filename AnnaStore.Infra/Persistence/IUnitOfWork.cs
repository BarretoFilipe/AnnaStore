using System;

namespace AnnaStore.Infra.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
