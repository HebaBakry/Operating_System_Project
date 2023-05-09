using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Assignment
{
    internal class SJFNonPreemptive
    {
        public static (float, float, List<GanttBlock>) SJFNon(List<Process> processes)
        {
            float timer = 0;
            //completion is number of completed processes
            int completion = 0;
            float totalWait = 0;
            float totalTurnAround = 0;
            //sorting by arrival time
            processes = processes.OrderBy(p => p.arrivalTime).ToList();

            List<GanttBlock> gantt = new List<GanttBlock>();

            
            PriorityQueue<Process, float> heap = new PriorityQueue<Process, float>();


            // i acts like a pointer to which process we accesed last
            int i = 0;
            while (completion < processes.Count)
            {
                //add processes to heap in the arrived, priority based on shortest burst, inQueue flag ensures no process duplication
                foreach (Process process in processes)
                {
                    if (process.arrivalTime <= timer && process.remainingTime > 0 && !process.inQueue)
                    {
                        heap.Enqueue(process, process.burstTime);
                        process.inQueue = true;
                        i++;
                        //Console.WriteLine("process in : "+ process.name +" "+ process.burstTime); //for debugging 
                    }
                    else if (process.arrivalTime <= timer && process.remainingTime == 0 && !process.inQueue)
                    {
                        if (i < processes.Count)
                        {
                            heap.Enqueue(process, process.burstTime);
                            process.inQueue = true;
                            i++;
                        }
                    }

                }

                //to handle idle case 
                if (heap.Count == 0)
                {
                    //gantt.Add(new GanttBlock("idle", timer, processes[i].arrivalTime));    //removed :(
                    timer = processes[i].arrivalTime;
                    continue;

                }

                // popping from heap shortest job, adding its gantt block, updating timer and total waiting time
                Process temp = heap.Dequeue();

                gantt.Add(new GanttBlock(temp.name, timer, timer + temp.burstTime, temp.burstTime));
                totalWait += timer - temp.arrivalTime;
                timer += temp.burstTime;
                temp.endTime = timer;

                temp.remainingTime = 0;
                //Console.WriteLine("process out: " + temp.name + " " + temp.burstTime); //for debugging

                //updates number of completed processes
                completion++;
            }

            foreach (Process process in processes)
            {
                totalTurnAround += (float) process.endTime - process.arrivalTime;
            }

            return (totalWait / processes.Count, totalTurnAround/ processes.Count, gantt);
        }
    }
}
