using System;

namespace AnnaStore.SharedKernel.Events.Contracts
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }
}
