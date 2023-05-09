using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Assignment
{
    public class GanttBlock
    {
        public string name;
        public float startTime, endTime,remainingTime ;

        public GanttBlock(string name, float startTime, float endTime, float remainingtime)
        {
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;
            this.remainingTime = remainingtime;
        }
    }

}
