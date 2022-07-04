using Microsoft.AspNetCore.Mvc;
using Student_Management.Models;
using System.Collections.Generic;
using System.Linq;

namespace Student_Management.Controllers
{
    public class TestController : Controller
    {
        student_managementContext context = new student_managementContext();
        public IActionResult Index()
        {
            List<Slot> slotList = context.Slots.ToList();
            ViewBag.SlotList = slotList;
            return View();
        }
    }
}
