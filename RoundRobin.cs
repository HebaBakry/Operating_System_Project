using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Assignment
{
    internal class RoundRobin
    {
        public static float qua;
        public static float checkArrivals(List<Process> processes, float quanta, Queue<Process> queue, float timer)
        {
            //queueEmpty flag to know when there are no processes in ready queue "idle"
            Boolean queueEmpty = true;

            //adding processes in ready queue
            foreach (Process process in processes)
            {
                if (process.remainingTime > 0 && !process.inQueue && process.arrivalTime <= timer)
                {
                    process.inQueue = true;
                    queue.Enqueue(process);
                    queueEmpty = false;
                    // for debugging
                    //Console.WriteLine("added to queue " + process.name + " at time: " + timer);
                }
            }

            //if ready queue is empty the method returns the new timer (arrival time of the process after idle)
            if (queueEmpty)
            {
                foreach (Process process in processes)
                {
                    if (process.arrivalTime <= timer)
                    {
                        continue;
                    }
                    else
                    {
                        timer = process.arrivalTime;
                        break;
                    }
                }
            }

            return timer;
        }
        public static (float, float, List<GanttBlock>) roundRobin(List<Process> processes, float quanta)
        {
            qua = quanta;
            List<GanttBlock> gantt = new List<GanttBlock>();

            int completion = 0;
            float totalWait = 0;
            float totalTurnAround = 0;

            //ready queue
            Queue<Process> queue = new Queue<Process>();

           
            /*total turn around = (end Times - arrival Times), 
             * since I don't know end times yet I start by subtracting arrival times then later end Times will be addded*/
            foreach (Process process in processes)
            {
                totalTurnAround -= process.arrivalTime;
            }


            float timer = 0;



            while (completion < processes.Count)
            {
                //sorting processes by arrival time
                processes = processes.OrderBy(p => p.arrivalTime).ToList();

                float newTimer = checkArrivals(processes, quanta, queue, timer);

                //updating timer in case of idle
                if (queue.Count == 0)
                {
                    //gantt.Add(new GanttBlock("idle", timer, newTimer));      // removed :(
                    timer = newTimer;
                    continue;

                }

                while (queue.Count > 0)
                {
                    //popping from ready queue, updating procces inQueue status, updating total wait
                    Process temp = queue.Dequeue();

                    temp.inQueue = false;
                    totalWait += timer - temp.arrivalTime;

                    //adding gantt block, updating timer and remaing time for process
                    gantt.Add(new GanttBlock(temp.name, timer, timer + Math.Min(quanta, temp.remainingTime), temp.burstTime));
                    timer += Math.Min(quanta, temp.remainingTime);
                    temp.remainingTime -= Math.Min(quanta, temp.remainingTime);
                    //for debugging
                    //Console.WriteLine("popped queue " + temp.name + " at time: " + timer);

                    //after a process is popped it needs to be in ready queue again so its new arrival time is = to timer when popped
                    temp.arrivalTime = timer;

                    //updating end time, total turn around, completion in case a process is finished
                    if (temp.remainingTime <= 0)
                    {
                        temp.endTime = timer;
                        totalTurnAround += timer;
                        completion++;
                    }

                }
            }

            return (totalWait / processes.Count, totalTurnAround / processes.Count, gantt);


        }
    }
}
