using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
	public class ActorController : Controller
	{
		private Moviecontext _db;

		public ActorController (Moviecontext db)
		{
			this._db = db;
		}

		// GET: ActorController1
		public ActionResult Index()
		{
			return View(_db.Actors.ToList());
		}

		// GET: ActorController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: ActorController1/Create
		public ActionResult Create()
		{
			return View();
		}

		public IActionResult AddActorToMovie(int id)
		{
			ViewBag.Movie = _db.Movies.ToList();
			ViewBag.Actor = _db.Actors.Find(id);

			return View();
		}

		[HttpPost]
		public IActionResult AddMovieToActor(int ActorId, Movie model)
		{
			ViewBag.Movies = _db.Movies.ToList();
			ViewBag.Actor = _db.Actors.Find(ActorId);

			var actor = _db.Actors.Find(ActorId);

			if (actor.Movies.Where(c => c.MovieId == model.Id).FirstOrDefault() == null)
			{
				_db.MovieActors.Add(new MovieActors() { ActorId = ActorId, MovieId = model.Id });
				_db.SaveChanges();
			}

			return RedirectToAction("AddMovieToActor");
		}


		// POST: ActorController1/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ActorController1/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: ActorController1/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ActorController1/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: ActorController1/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
