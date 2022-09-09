using PackIT.Domain.ValueObjects;
using PackIT.Domain.Exceptions;
using PackIT.Shared.Abstractions.Domain;
using PackIT.Domain.Events;

namespace PackIT.Domain.Entities
{
   //! i will not use a natural identity for this entity such as the Name of the package because 
   //! many users can create a packing list with the same name, so we need to avoid this.
   public class PackingList : AggregateRoot<PackingListId>
   {
      //* private setter to encapsulate the id
      // ===> The idnetifier should still public and its get method should also still public because its my only way to access this entity
      public Guid PackingListId { get; private set; }
      // ===> The Domain Technicality Properties must be private so that they can not be changed by the Application Layer
      //* for natural-human readable identity
      private PackingListName _name;
      //* the destination
      private Localization _localization;
      //* the items in this package
      private readonly LinkedList<PackingItem> _items  = new();
      // Constructor
      internal PackingList(Guid id, PackingListName name, Localization localization, LinkedList<PackingItem> items)
      {
         Id = id;
         _name = name;
         _localization = localization;
         _items = items;
      }

      //! Methods to add and remove items from the list
      public void AddItem(PackingItem item)
      {
         var existingItem = this._items.Any(i => i.Name == item.Name);
         if (existingItem){
            throw new PackingItemAlreadyExistsException(_name, item.Name);
         }else{
            _items.AddLast(item);
            AddEvent(
               new PackingItemAdded(this, item)
            );
         }
      }
      public void AddItems (IEnumerable<PackingItem> items)
      {
         foreach (var item in items)
         {
            AddItem(item);
         }
      }
      public void PackItem(string itemName)
      {
         var existingItem = GetItem(itemName);
         var packedItem = existingItem with {IsPacked=true};
         _items.Find(existingItem).Value = packedItem;
         AddEvent(
            new PackingItemPacked(this, existingItem)
         );
      }
      public void RemoveItem(string itemName)
      {
         var item = GetItem(itemName);
         _items.Remove(item);
         AddEvent(
            new PackingItemRemoved(this, item)
         );
      }

      private PackingItem GetItem(string itemName)
      {
         var item = _items.SingleOrDefault(i => i.Name == itemName);
         if (item == null){
            throw new PackingItemNotFoundException(itemName);
         }
         return item;
      }

   }
}