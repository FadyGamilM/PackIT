using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
   public class TravelDaysException : PackItException
   {
      public TravelDaysException() : base ("number of travel days can not be less than 0 or mroe than 100")
      {         
      }
   }
}