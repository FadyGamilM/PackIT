using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
   public class PackingItemNotFoundException : PackItException
   {
      public string itemName{get;}

      public PackingItemNotFoundException(string itemName) : base ($"there is no item with name $'{itemName}'")
      {
         this.itemName = itemName;
      }
   }
}