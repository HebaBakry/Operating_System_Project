using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Assignment
{
    internal class Process
    {
        public String name;
        public float arrivalTime;
        public float burstTime;
        public float remainingTime; 
        public int? priority;
        public float? endTime;
        public Boolean inQueue = false;
        public static int count = 0;

        public Process(float arrivalTime, float burstTime, int? priority = null)
        {
            count++;
            this.name = "P" + count;
            this.arrivalTime = arrivalTime;
            this.burstTime = burstTime;
            this.priority = priority;
            this.remainingTime=burstTime;
        }
    }
}