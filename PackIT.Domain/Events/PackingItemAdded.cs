using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Domain;

namespace PackIT.Domain.Events
{
   public record PackingItemAdded(PackingList paclinglist, PackingItem packingItem) : IDomainEvent;
}