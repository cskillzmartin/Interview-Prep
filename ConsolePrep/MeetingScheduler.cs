using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    public class MeetingScheduler
    {
        public static meeting[] Candidates(int num)
        {
            var rtnValue = new meeting[num];
            var rando = new Random();
            for (int i = 0; i < num; i++)
            {
                rtnValue[i] = new meeting()
                {
                    Name = "Meeting " + i.ToString(),
                    Hours = rando.Next(1, 3)
                };
            }

            return rtnValue;
        }

        public static Schedule GetSchedule(meeting[] meetings, int maxTime)
        {
            var rtnValue = new Schedule();

            for (int i = 0, j = meetings.Length - 1; i < meetings.Length && rtnValue.AvailableTime < maxTime; i++, j--)
            {
                if (rtnValue.AvailableTime + meetings[i].Hours <= maxTime)
                    rtnValue.Meetings.Add(meetings[i]);

                if (rtnValue.AvailableTime + meetings[j].Hours <= maxTime)
                    rtnValue.Meetings.Add(meetings[j]);
            }
            return rtnValue;
        }

    }

    public class meeting
    {
        public string Name { get; set; }
        public int Hours { get; set; }
    }

    public class Schedule
    {
        public Schedule()
        {
            Meetings = new List<meeting>();
        }
        public IList<meeting> Meetings { get; set; }

        public int AvailableTime { get { return _AvailableTime(); } }
        private int _AvailableTime()
        {
            int rtnValue = 0;
            for (int i = 0; i < Meetings.Count; i++)
            {
                rtnValue += Meetings[i].Hours;
            }
            return rtnValue;
        }
    }
}
