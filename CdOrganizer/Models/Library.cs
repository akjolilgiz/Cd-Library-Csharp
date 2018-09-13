using System.Collections.Generic;
using System;

namespace CdOrganizer.Models
{
  public class Library
  {
    private static List<Library> _instances = new List<Library> {};
    private string _artistLibrary;
    private int _id;
    private List<Cds> _cds;

    public Library(string artistLibrary)
    {
      _artistLibrary = artistLibrary;
      _instances.Add(this);
      _id = _instances.Count;
      _cds = new List<Cds>{};
    }

    public string GetArtistLibrary()
    {
      return _artistLibrary;
    }
    public int GetId()
    {
      return _id;
    }
    public List<Cds> GetCds()
    {
      return _cds;
    }
    public void AddCd(Cds cds)
    {
      _cds.Add(cds);
    }
    public static List<Library> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Library Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
