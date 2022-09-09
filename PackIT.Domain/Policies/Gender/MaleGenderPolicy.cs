using PackIT.Domain.ValueObjects;
using PackIT.Domain.Constants;
namespace PackIT.Domain.Policies.Gender
{
   internal class MaleGenderPolicy : IPackingItemsPolicy
   {
      public IEnumerable<PackingItem> GenerateItems(PolicyData data)
         => new List<PackingItem>{
                  new ("Laptop", 1),
                  new ("Beer", 10),
                  new ("Book", (uint) Math.Ceiling(data.days / 7m))
               };

      public bool IsApplicable(PolicyData data)
         => data.gender is Constants.Gender.Male;
   }
}