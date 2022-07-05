using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        student_managementContext context = new student_managementContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TimeTable()
        {
            var ls = context.Schedules.ToList();
            Dictionary<int, List<Schedule>> map = new Dictionary<int, List<Schedule>>();
            for (int i = 1; i <= 8; i++)
            {
                List<Schedule> schedules = new List<Schedule>();
                foreach (var s in ls)
                {
                    if (s.SlotId == i)
                    {
                        schedules.Add(s);
                    }
                }
                map.Add(i, schedules);
            }
            Dictionary<int, Dictionary<string, Schedule>> map2 = new Dictionary<int, Dictionary<string, Schedule>>();
            foreach (var m in map)
            {
                int key = m.Key;
                List<Schedule> schedules = m.Value;
                Dictionary<string, Schedule> map3 = new Dictionary<string, Schedule>();
                foreach (var item in schedules)
                {
                    map3.Add(Convert.ToDateTime(item.ScheduleDate).ToString("dd/MM/yyyy"), item);
                }
                map2.Add(key, map3);
            }

            var date_raw = (from Schedule in context.Schedules
                            select Schedule.ScheduleDate).Distinct().ToList();
            List<String> listDate = new List<String>();
            for (int i = 0; i < date_raw.Count; i++)
            {
                listDate.Add(Convert.ToDateTime(date_raw[i]).ToString("dd/MM/yyyy"));
            }

            ViewBag.TimeTable = map2;
            List<Slot> listSlot = context.Slots.ToList();
            ViewBag.Subject = context.Subjects.ToList();
            ViewBag.Class = context.Classes.ToList();
            ViewBag.slot = listSlot;
            ViewBag.Date = listDate;
            return View();
        }
    }
}
