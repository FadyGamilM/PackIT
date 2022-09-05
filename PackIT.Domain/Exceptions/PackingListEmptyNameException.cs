using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
   public class PackingListEmptyNameException : PackItException
   {
      public PackingListEmptyNameException() : base("Packing list name cannot be empty")
      {
      }
   }
}