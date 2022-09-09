using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
   public class PackingItemEmptyNameException : PackItException
   {
      public PackingItemEmptyNameException() : base("Packing item name cannot be empty")
      {
      }
   }
}