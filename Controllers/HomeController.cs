using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LostInTheWoods.Models;
using DbConnection;

namespace LostInTheWoods.Controllers
{
    public class HomeController : Controller
    {
        private List<Dictionary<string, object>> AllTrails
        {
            get
            {
                return DbConnector.Query("SELECT * FROM trails;");
            }
        }

        public IActionResult Index()
        {
            return View(AllTrails);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View("NewTrail");
        }

        [HttpPost("create")]
        public IActionResult Create(string name, string description, double length, int elevation, string longitude, string latitude)
        {
            string insert = $"INSERT INTO trails (name, description, length, elevation, longitude, latitude) VALUES ('{name}','{description}','{length}','{elevation}','{longitude}','{latitude}')";
            DbConnector.Execute(insert);
            return RedirectToAction("Index");
        }

        [HttpGet("view/{id}")]
        public IActionResult View(int id)
        {
            var view_trail = DbConnector.Query($"SELECT * FROM trails WHERE id = '{id}'")[0];
            return View("ViewTrail", view_trail);
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            string delete_trail = $"DELETE FROM trails WHERE id = '{id}'";
            DbConnector.Execute(delete_trail);
            return RedirectToAction("Index");
        }

    

        // [HttpGet("/click")]
        // public IActionResult Click()
        // {
        //     return PartialView("TrailsPartial", AllTrails);
        // }

        // [HttpGet("quotes")]
        // public IActionResult Trails()
        // {
        //     return PartialView("TrailsPartial", AllTrails);
        // }
        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
