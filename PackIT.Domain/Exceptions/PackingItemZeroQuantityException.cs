using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
   public class PackingItemZeroQuantityException : PackItException
   {
      public PackingItemZeroQuantityException() : base("Packing item quantity cannot be zero")
      {
      }
   }
}