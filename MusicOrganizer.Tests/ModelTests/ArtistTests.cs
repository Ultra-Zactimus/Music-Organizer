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
      Artist.ClearAll();
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


    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Test Artist Name";
      Artist newArtist = new Artist(name);

      //Act
      int result = newArtist.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllArtistObjects_ArtistList()
    {
      Artist newArtist1 = new Artist("Frodo");
      Artist newArtist2 = new Artist("Bilbo");
      List<Artist> artists = new List<Artist>{ newArtist1, newArtist2};

      CollectionAssert.AreEqual(artists, Artist.GetAll() );
    }

    [TestMethod]
    public void Find_ReturnsCorrectArtist_Artist()
    {
      string name1 = "artist1";
      string name2 = "artist2";
      Artist newArt1 = new Artist(name1);
      Artist newArt2 = new Artist(name2);

      Artist result = Artist.Find(2);

      Assert.AreEqual(newArt2, result);
    }

  }
}