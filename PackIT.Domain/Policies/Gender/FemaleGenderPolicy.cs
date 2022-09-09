using PackIT.Domain.ValueObjects;
using PackIT.Domain.Constants;
namespace PackIT.Domain.Policies.Gender
{
   internal class FemaleGenderPolicy : IPackingItemsPolicy
   {
      public IEnumerable<PackingItem> GenerateItems(PolicyData data)
         => new List<PackingItem>{
                  new ("Lipstic", 1),
                  new ("powder", 1),
                  new ("EyeLiner", 1)
               };

      public bool IsApplicable(PolicyData data)
         => data.gender is Constants.Gender.Female;
   }
}