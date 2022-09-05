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
            // through exception;
         }
         Value = value;
      }
   }
}