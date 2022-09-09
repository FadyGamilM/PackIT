using PackIT.Domain.ValueObjects;
namespace PackIT.Domain.Policies
{
   public record PolicyData(
      TravelDays days,
      Constants.Gender gender,
      ValueObjects.Temperature temperature,
      Localization localization
   );
}