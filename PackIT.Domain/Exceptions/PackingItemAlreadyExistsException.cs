namespace PackIT.Domain.Exceptions
{
   public class PackingItemAlreadyExistsException : Exception
   {
      public string ListName { get; }
      public string ItemName { get; }

      public PackingItemAlreadyExistsException(string listName, string itemName) 
         : base($"The item '{itemName}' already exists in the packing list '{listName}'")
      {
         ListName = listName;
         ItemName = itemName;
      }

   }
}