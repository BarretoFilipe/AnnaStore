using AnnaStore.SharedKernel.Events.Contracts;
using System;
using System.Collections.Generic;

namespace AnnaStore.SharedKernel
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        List<T> GetValue();
        bool HasNotifications();
    }
}
