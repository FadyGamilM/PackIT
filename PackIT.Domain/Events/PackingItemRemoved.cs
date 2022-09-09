
using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Domain;

namespace PackIT.Domain.Events
{
   public record PackingItemRemoved
      (PackingList paclingList, PackingItem packingItem) : IDomainEvent;
}