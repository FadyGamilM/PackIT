using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects
{
   public record PackingListName
   {
      public string Value { get;  }
      public PackingListName(string value)
      {
         // validate if this string is empty or not
         if (string.IsNullOrWhiteSpace(value))
         {
            // through the domain layer custom exception
            throw new PackingListEmptyNameException();
         }
         Value = value;
      }

      // Implicit conversion from string to packingListName and vice versa
      public static implicit operator string(PackingListName name) => name.Value;
      public static implicit operator PackingListName(string name) => new PackingListName(name);
   }
}