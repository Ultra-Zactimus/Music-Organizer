using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {

    public void Dispose()
    {
      // Artist.ClearAll();
    }
    
    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("Coolio");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Coolio";
      Artist newArtist = new Artist(name);

      Assert.AreEqual(name, newArtist.Name);
    }

  }
}