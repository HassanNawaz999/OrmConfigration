using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrmConfigrationDemo.Models;

namespace OrmConfigrationDemo.Controllers
{
    public class OrmDemoController : Controller
    {
        //DEMANDING DB CONTEXT IN CONTROLLER
        dbPlayerContext mydbcontext = null;

        public OrmDemoController(dbPlayerContext _mydbcontext)
        {
            mydbcontext = _mydbcontext;
        }
        [HttpGet]
        public IActionResult AddRecodeSample()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRecodeSample(TblPlayerInfo ti)
        {
            mydbcontext.TblPlayerInfo.Add(ti);
            mydbcontext.SaveChanges();
            return View();
        }
    }
}