using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    }
}
