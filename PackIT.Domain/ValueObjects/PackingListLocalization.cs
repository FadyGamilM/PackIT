using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects
{
   public record Localization (string City, string Country)
   {
      // Type Conversion
      public static Localization Create(string value)
      {
         var splitLocalization = value.Split(',');
         return new Localization(splitLocalization.First(), splitLocalization.Last());
      }
      // override the ToString method to return the value of the localization
      public override string ToString() => $"{City}, {Country}";
   }
}