using MusicOrganizer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class ArtistController : Controllers
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }

    [HttpGet("artists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      return RedirectToAction("Index");
    }

    [HttpeGet("artists/{Id}")]
    public ActionResult Show(int Id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist selectedArtist = Artist.Find(id);
      List<Record> artistRecords = selectedArtist.Records;
      model.Add("artist", selectedArtist);
      model.Add("records", artistRecords);
      return View(model);
    }

    [HttpPost("/artists/{cartistId}/records")]
    public ActionResult Create(int artistId, string recordDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist foundArtist = Artist.Find(artistId);
      Record newRecord = new Record(recordDescription);
      foundArtist.AddRecord(newRecord);
      List<Record> artistRecords = foundArtist.Records;
      model.Add("records", artistRecords);
      model.Add("artist", foundArtist);
      return View("Show", model);
    }
  }
}