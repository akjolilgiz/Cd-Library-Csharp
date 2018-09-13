using System.Collections.Generic;
using System;
namespace CdOrganizer.Models
{
  public class Cds
  {
    private string _title;
    private string _artist;
    private int _id;

    private static List<Cds> _instances = new List<Cds> {};

    public Cds(string title)
    {
      _title = title;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetTitle()
    {
      return _title;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }

    public string GetArtist()
    {
      return _artist;
    }
    public void SetArtist(string artist)
    {
      _artist = artist;
    }

    public int GetId()
    {
      return _id;
    }
    public static List<Cds> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Cds Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
