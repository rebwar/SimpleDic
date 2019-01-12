using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleDic.Data;

namespace SimpleDic.Controllers
{
    public class DictionaryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DictionaryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var model = _db.dictionaries;
            return View(model);
        }
    }
}