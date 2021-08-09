using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList.Controllers
{
    public class HomeController:Controller
    {
        StudentGroupContext Context;

        public HomeController(StudentGroupContext context)
        {
            Context = context;
        }

        public IActionResult Home()
        {
            var d = Context.Students.Where(s => s.GroupId == 1).ToList();

            var strudentGroup = Context.Groups.Include(p => p.Students);
            return View(strudentGroup.ToList());
        }
        

        public IActionResult AddOrEdit( int id)
        {
            SelectList groups = new SelectList(Context.Groups, "Id", "GroupName");

            ViewBag.Groups = groups;
            if (id == 0)
                return View(new Student());
            return View(Context.Students.Find(id));
        }

        //[HttpPost]
        ////public async
    }
}
