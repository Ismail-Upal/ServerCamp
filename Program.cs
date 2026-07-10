using System.Dynamic;

public class House
{
   public List Rooms { get; } = new();
   public House()
   {
      Rooms.Add(new Room("Living Room"));
      Rooms.Add(new Room("Kitchen"));
   }
   public class Room
   {
      public string Name { get; }
      public Room(string name)
      {
         Name = name;
      }
   }        
}

