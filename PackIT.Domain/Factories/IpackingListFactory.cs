using PackIT.Domain.Constants;
using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;
namespace PackIT.Domain.Factories
{
   public interface IPackingListFactory
   {
      // we can create an empty packing list and add the items one by one manually later
      PackingList Create(PackingListId id, PackingListName name, Localization localization);
      // or we can create a packing list with additional info by default
      PackingList CreateWithDefaultItems(
         PackingListId id, 
         PackingListName name, 
         TravelDays days, 
         Gender gender,
         Temperature temperature, 
         Localization localization);
   }
}