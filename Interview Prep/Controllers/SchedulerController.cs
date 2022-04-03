using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class SchedulerController : Controller
    {
        public ActionResult Index()
        {

            return View(GetMaxMeetings(8, BuildMeetingList()));
        }


        public IList<Meeting> GetMaxMeetings(int target, IList<Meeting> meetings)
        {
            var rtnValue = new List<Meeting>();
            var table = new List<KeyValuePair<int, string>>();
            int i = 0;
            while (target >= 0 && i < meetings.Count)
            {
                if (target - meetings[i].Length > 0)
                {
                    target -= meetings[i].Length;
                    rtnValue.Add(meetings[i]);
                    meetings.RemoveAt(i);
                }
                i++;
            }
            if (target > 0)
            {
                for (int j = 0; j < meetings.Count; j++)
                {
                    if (meetings[j].Length == target)
                    {
                        target -= meetings[j].Length;
                        rtnValue.Add(meetings[j]);
                        meetings.RemoveAt(j);
                        return rtnValue;
                    }
                }
            }


            return rtnValue;
        }


        public IList<Meeting> BuildMeetingList()
        {
            var rtnValue = new List<Meeting>();
            var rando = new Random();
            for (int i = 0; i < 15; i++)
            {
                rtnValue.Add(new Meeting()
                {
                    Name = "Meeting " + i.ToString(),
                    Length = rando.Next(1, 3)
                });
            }
            return rtnValue;
        }
    }




    public class Meeting
    {
        public string Name { get; set; }

        public int Length { get; set; }
    }
}