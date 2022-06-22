using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRN291_StudentManagerment.Models;
using System.Collections.Generic;
using System.Linq;

namespace PRN291_StudentManagerment.Controllers
{
    public class SlotController : Controller
    {
        // GET: SlotController
        public ActionResult Index()
        {
            //1. Get Connnection DB
            var context = new student_managementContext();
            //2. Create Slot List
            List<Slot> slotList = context.Slots.ToList();
            //3. Push model to Index
            return View(slotList);
        }

        // GET: SlotController/Details/5
        public ActionResult Details(int id)
        {
            var context = new student_managementContext();
            Slot slot = context.Slots.Where(slot => slot.SlotId == id).FirstOrDefault();
            return View(slot);
        }

        // GET: SlotController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SlotController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Slot slot)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new student_managementContext();
                context.Slots.Add(slot);
                context.SaveChanges();
                //Send Redirect To Action Index
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SlotController/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new student_managementContext();
            Slot slot = context.Slots.Where(slot => slot.SlotId == id).FirstOrDefault();
            return View(slot);
        }

        // POST: SlotController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Slot slot)
        {
            try
            {
                // TODO: Add update logic here
                var context = new student_managementContext();
                Slot oldSlot = context.Slots.Where(x => x.SlotId == slot.SlotId).FirstOrDefault();
                oldSlot.SlotTime = slot.SlotTime;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SlotController/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new student_managementContext();
            Slot slot = context.Slots.Where(slot => slot.SlotId == id).FirstOrDefault();
            return View(slot);
        }

        // POST: SlotController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new student_managementContext();
                Slot slot = context.Slots.Where(slot => slot.SlotId == id).FirstOrDefault();
                context.Slots.Remove(slot);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
