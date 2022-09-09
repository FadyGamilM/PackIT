using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
   public class PackingListEmptyIdentifierException : PackItException
   {
      public PackingListEmptyIdentifierException() : base("the identifier of the packing list can not be empty")
      {
         
      }  
   }
}