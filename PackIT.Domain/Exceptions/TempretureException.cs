using PackIT.Shared.Abstractions.Exceptions;
namespace PackIT.Domain.Exceptions
{
   public class TemperatureException : PackItException
   {
      public TemperatureException():base("Temperature cannot be more than 100 degree or less than -100 degree")
      {
         
      }
   }
}