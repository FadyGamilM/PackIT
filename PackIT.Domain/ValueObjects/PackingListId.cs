using PackIT.Domain.Exceptions;

namespace PackIT.Domain.ValueObjects
{
   public record PackingListId
   {
      public Guid Value {get;}

      public PackingListId(Guid Id)
      {
         if (Id == Guid.Empty){
            throw new PackingListEmptyIdentifierException();
         }
         Value = Id;
      }

      public static implicit operator Guid (PackingListId packingID)
         => packingID.Value;
      
      public static implicit operator PackingListId (Guid Id)
         => new PackingListId(Id);
   }
}