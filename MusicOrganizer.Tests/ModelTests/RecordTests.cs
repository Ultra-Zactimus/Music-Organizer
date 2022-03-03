using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class RecordTests : IDisposable
  {
    public void Dispose()
    {
      Record.ClearAll();
    }

    [TestMethod]
    public void Record_ShouldCreateInstanceOfRecord_Object()
    {
      Record record = new Record("test");
      Assert.AreEqual(typeof(Record), record.GetType());
    }

    [TestMethod]
    public void Record_ShouldCreateAblum_Record()
    {
      string album = "1994";
      Record record = new Record(album);
      string result = record.Album;
      Assert.AreEqual(album, result);
    }

    [TestMethod]
    public void GetAll_ShouldReturnAnEmptyList_List()
    {
      List<Record> instances = new List<Record>{};
      List<Record> result = Record.GetAll();
      CollectionAssert.AreEqual(instances, result);
    }

    [TestMethod]
    public void GetAll_ShouldReturnAnInstancesOfRecord_Album()
    {
      string album1 = "Darkside of the Moon";
      string album2 = "Fall of Ziggy Stardust";
      Record record1 = new Record(album1);
      Record record2 = new Record(album2);
      List<Record> newList = new List<Record> { record1, record2 };

      List<Record> result = Record.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}