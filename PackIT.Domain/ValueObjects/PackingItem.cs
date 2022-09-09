using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects
{
   public record PackingItem
   {
      public string Name { get;  }
      public int Quantity { get;  }
      public bool IsPacked { get; init;}

      public PackingItem(string name, int quantity, bool isPacked)
      {
         // item name validation 
         if (string.IsNullOrWhiteSpace(name))
         {
            throw new PackingItemEmptyNameException();
         }
         else
         {
            Name = name;
         }
         // item quantity validation
         if (quantity <= 0)
         {
            throw new PackingItemZeroQuantityException();
         }
         else
         {
            Quantity = quantity;
         }
         IsPacked = isPacked;
      }
   }
}