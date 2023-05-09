using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Assignment
{
	internal class PriorityNonPreemptive
	{
		 /*Function Description: a Function to schedule processes according to priority non-preempitve scheduling
		 *Input:a list of all processes
		 *Output:A tuple of following order:(average waiting time,average turn around time and list of gantt blocks created)
		 */
		public static (float, float, List<GanttBlock>) Priority_NP(List<Process> processes)
		{
			float totalWaitingTime = 0;
			float totalTurnAroundTime = 0;
			Process dequeued;
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
				Process holder=APQ.Dequeue();
				/*Adding unprocessed processes to priority queue based on their priority*/
				foreach (Process P in processes)
				{
					if (P.arrivalTime <= time && P.remainingTime != 0 && P.inQueue == false)
					{
						PPQ.Enqueue(P, P.priority.Value);
					}
				}
				/*Handles the case of an idle slot*/
				if (PPQ.Count == 0)
				{
					if (ganttBlocks.Count > 0)
					{
						APQ.Enqueue(holder, holder.arrivalTime);
						time += holder.arrivalTime - ganttBlocks[ganttBlocks.Count - 1].endTime;/*to move our timeline to the point where we have a new process*/
						continue;
					}
						
				}
				if (holder.remainingTime != 0 || (PPQ.Count>0 &&(!(ganttBlocks.Contains(new GanttBlock(holder.name, time, time + holder.burstTime, holder.burstTime))))))
				{
					dequeued = PPQ.Dequeue();
				}
				else {
                     dequeued = holder;
                }
			    /*Creating a gantt block with dequeued process*/
				ganttBlocks.Add(new GanttBlock(dequeued.name, time, time + dequeued.burstTime, dequeued.burstTime));
				/*calculation of Total around time and total waiting time*/
				totalTurnAroundTime += ((time + dequeued.burstTime) - dequeued.arrivalTime);

				totalWaitingTime += ((time + dequeued.burstTime) - dequeued.arrivalTime - dequeued.burstTime);
				/*Process is completed successfully*/
				dequeued.remainingTime = 0;
				dequeued.inQueue = true;
				/*Timeline is kept up to current instant*/ 
				time += dequeued.burstTime;
				PPQ.Clear(); /*To clear Redundant Processes*/
			}
			return (totalWaitingTime / processes.Count, totalTurnAroundTime / processes.Count, ganttBlocks);

			/* Sorting The processes based on its Priority */
			//processes.Sort((a, b) => a.priority.Value.CompareTo(b.priority.Value));

			/* adding the first gantt block which starts from 0 */
			// ganttBlocks.Add(new GanttBlock(processes[0].name, 0, processes[0].burstTime));

			//for (int i = 1; i < processes.Count; i++)
			//{
			//    /* the endtime of previous gantt block is the same as the start time of the next gantt block */
			//    float pStartTime = ganttBlocks[i - 1].endTime;

			//    /* the time at which the process finishes its burst */
			//    float pFinishTime = pStartTime + processes[i].burstTime;

			//    /* Adding a new gantt block starts at the pervious endtime and ends after its burst time */
			//    ganttBlocks.Add(new GanttBlock(processes[i].name, pStartTime, pFinishTime));

			//    /*
			//     * Calculating the waiting time of the current process
			//     * waiting time = pFinishTime - pArrivalTime
			//     * but the arrival time = zero 
			//     * then, waiting time = pFinishTime
			//     */
			//    totalWaitingTime += pFinishTime;
			//}

			/* the average waiting time is the total waiting time over the number of processes */
			
		}
	}
}
