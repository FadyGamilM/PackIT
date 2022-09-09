using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects
{
   public record Temperature
   {
      public double Value {get;}
      public Temperature(double temperature)
      {
         if (temperature is -100 or 100){
            throw new TemperatureException();
         }
         Value = temperature;
      }
      public static implicit operator double(Temperature temp)
         => temp.Value;
      
      public static implicit operator Temperature(double temp)
         => new Temperature(temp);
   }
}