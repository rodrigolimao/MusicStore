using fri_am_music_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Models
{
    public class AlbumsController : Controller
    {
        // GET: Albums
        public ActionResult Index()
        {
            var albums = new List<Album>();

            //Make a mock list of the albums
            for (int i = 1; i <= 10; i++)
            {
                albums.Add(new Album { Title = "Album " + i.ToString() });
            }

            //pass the mock date to the view
            //ViewBag.albums = albums;

            //pass the strongly-typed album list directyl to the view
            return View(albums);
        }
    }
}