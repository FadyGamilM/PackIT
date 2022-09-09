namespace PackIT.Shared.Abstractions.Domain
{
   // <T> is the type of identifier
   public abstract class AggregateRoot <T>
   {
      public T Id {get; protected set;}
      // for checking on the database level 
      public int Version {get; protected set;}
      private bool _versionIncremented;

      // Encapsulation for handling the events
      private readonly List<IDomainEvent> _events = new();
      public IEnumerable<IDomainEvent> Events => _events;
      protected void AddEvent (IDomainEvent @event)
      {
         // for the first time
         if(!_events.Any() && !_versionIncremented)
         {
            Version++;
            _versionIncremented = true;
            _events.Add(@event);
         }
      }
      public void ClearEvents() => _events.Clear();

      protected void IncrementVersion()
      {
         if (_versionIncremented){
            return;
         }

         Version++;
         _versionIncremented = true;
      }
   }
}