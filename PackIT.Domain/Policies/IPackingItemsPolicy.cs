using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies
{
   public interface IPackingItemsPolicy
   {
      // is this item is applicable to our policy or not ?
      bool IsApplicable(PolicyData data);
      IEnumerable<PackingItem> GenerateItems (PolicyData data);
   }
}