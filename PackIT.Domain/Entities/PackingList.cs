namespace PackIT.Domain.Entities
{
      //! i will not use a natural identity for this entity such as the Name of the package because 
      //! many users can create a packing list with the same name.
   public class PackingList
   {
      //* private setter to encapsulate the id
      // ===> The idnetifier should still public and its get method should also still public because its my only way to access this entity
      public Guid Id { get; private set; }
      // ===> The Domain Technicality Properties must be private so that they can not be changed by the Application Layer
      //* for natural-human readable identity
      private string _name;
      //* the destination
      private String _localization;
   }
}