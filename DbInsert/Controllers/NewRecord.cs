using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbInsert.Models;
using MySql.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DbInsert.Controllers
{
    public class NewRecord : Controller
    {

        private readonly ConnectionStringClass conn;

        public NewRecord(ConnectionStringClass cc)
        {
            conn = cc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmpClass ec)
        {
            conn.Add(ec);
            // bug here inner bug
            conn.SaveChanges();
            ViewBag.message =ec.fname + " Has been successsfully Added";
            return View(ec);
        }
    }
}
