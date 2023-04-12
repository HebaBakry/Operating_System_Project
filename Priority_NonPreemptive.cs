using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Assignment
{
    internal class Priority_NonPreemptive
    {
        /*Function to schedule processes according to priority non-preempitve scheduling
            Input:a list of all processes
            Output:a tuple of following order:(average waiting time,average turn around time and list of gantt blocks created)
        */
        public static (float, float, List<GanttBlock>) Priority_NP(List<Process> processes)
        {
            float totalWaitingTime = 0;
            float totalTurnAroundTime = 0;
            List<GanttBlock> ganttBlocks = new List<GanttBlock>();
            PriorityQueue<Process, int> PPQ = new PriorityQueue<Process, int>();/*A priority queue arrival prioirty based*/
            PriorityQueue<Process, float> APQ = new PriorityQueue<Process, float>(); /*A priority queue arrival time based*/
            foreach (Process p in processes)
            {
                APQ.Enqueue(p, p.arrivalTime);
            }
            float time = APQ.Peek().arrivalTime; /*Variable to keep with our timeline starting at first process*/
            while (APQ.Count > 0)
            {
                Process holder = APQ.Dequeue(); //dequeue first arrival process
                /*Adding unprocessed processes to priority queue based on their priority*/
                foreach (Process P in processes)
                {
                    if (P.arrivalTime <= time && P.remainingTime != 0)
                    {
                        PPQ.Enqueue(P, P.priority.Value);
                    }
                }
                /*Handles the case of an idle slot*/
                if (PPQ.Count == 0)
                {
                    APQ.Enqueue(holder, holder.arrivalTime);
                    time += holder.arrivalTime - ganttBlocks[ganttBlocks.Count - 1].endTime;/*to move timeline to the point where we have a new process*/
                    continue;

                }
                Process dequeued = PPQ.Dequeue();
                /*Creating a gantt block with dequeued process*/
                ganttBlocks.Add(new GanttBlock(dequeued.name, time, time + dequeued.burstTime));
                /*calculation of Total around time and total waiting time*/
                totalTurnAroundTime += ((time + dequeued.burstTime) - dequeued.arrivalTime);

                totalWaitingTime += ((time + dequeued.burstTime) - dequeued.arrivalTime - dequeued.burstTime);
                /*Process is completed successfully*/
                dequeued.remainingTime = 0;
                /*Timeline is kept up to current instant*/
                time += dequeued.burstTime;
                PPQ.Clear(); /*To clear Redundant Processes*/ //delete all elements in queue
            }
            return (totalWaitingTime / processes.Count, totalTurnAroundTime / processes.Count, ganttBlocks);
            //return (totalWaitingTime / processes.Count, totalTurnAroundTime / processes.Count);
        }

    }
}