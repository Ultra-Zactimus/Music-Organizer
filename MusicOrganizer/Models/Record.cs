using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Record
  {
    public string Album { get; set; }
    public int Id { get; }
    private static List<Record> _instances = new List<Record>{};

    public Record(string album)
    {
      Album = album;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Record>GetAll()
    {
      return _instances;
    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Record Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}