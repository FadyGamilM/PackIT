using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
   public class PackingListEmptyLocalizationException : PackItException
   {
      public PackingListEmptyLocalizationException() : base("The localization of the packing list can not be empty")
      {
      }
   }
}