using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Assignment
{
    internal class FCFS
    {
        /*Description:First Come Fist Server Scheduling Algorithm Function used to schedule processes
         *Input:List of Processes
         *Output:a Tuple of the follwoing Order:Avg waiting time ,avg turn around time and List of GanttBlocks 
         */
           public static (float, float, List<GanttBlock>) FCFS_Schedule(List<Process> Processes)
            {
                int count = 0; /*Counter to count number of processes*/
                float AvgWaitingTime = 0;

                float AvgTurnAroundTime = 0;

                List<GanttBlock> ganttBlocks = new List<GanttBlock>();
                /*Creating a priority Queue according to arrival time*/
                PriorityQueue<Process, float> heap = new PriorityQueue<Process, float>();

                foreach(Process p in Processes)  
                {
                    heap.Enqueue(p,p.arrivalTime);
                    count++;
                }
                /*Variable to Keep up with our GanttChart time axis*/
                float Time = heap.Peek().arrivalTime;
               
                while (heap.Count > 0)
                {
                    Process dequeued = heap.Dequeue();
                    if (Time < dequeued.arrivalTime)
                    {
                        Time += (dequeued.arrivalTime - Time);
                        heap.Enqueue(dequeued, dequeued.arrivalTime);
                        continue;
                    }
                    
                    GanttBlock addedBlock = new GanttBlock(dequeued.name, Time, Time + dequeued.burstTime, dequeued.burstTime);
                    
                    ganttBlocks.Add(addedBlock);

                    Time += dequeued.burstTime;
                    /*Formula To get turn around time*/
                    AvgTurnAroundTime += addedBlock.endTime - dequeued.arrivalTime;
                    /*Formula To get waiting time*/
                    AvgWaitingTime += addedBlock.endTime - dequeued.arrivalTime - dequeued.burstTime;
                  
                    /*if(heap.Count==0)
                    { 
                       Time-=dequeued.burstTime;
                    }*/
                }
          
                AvgWaitingTime = AvgWaitingTime / count;

                AvgTurnAroundTime = AvgTurnAroundTime / count;

                return (AvgWaitingTime, AvgTurnAroundTime, ganttBlocks);
                
            }
        
    }
}
