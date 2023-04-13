using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Assignment
{
    internal class PriorityPreemptive
    {
        /*a Function to schedule processes according to priority preempitve scheduling
            Input:a list of all processes
            Output:a tuple of (average waiting time,average turn around time, list of gantt blocks created)
         */
        public static (float, float, List<GanttBlock>) Priority_P(List<Process> processes)
        {
            float totaWaitingTime = 0, totaTurnAroundTime = 0;
            List<GanttBlock> ganttBlocks = new List<GanttBlock>();

            /* A list of all Arrival times to store our check points in time */
            List<float> checkTimes = new List<float>();
            foreach (Process process in processes)
            {
                checkTimes.Add(process.arrivalTime);
            }

            /* Sorting check points ascending*/
            checkTimes.Sort();

            /* To remove Duplicate check times */
            checkTimes = checkTimes.Distinct().ToList();


            /* a List to add already arrived processes */
            List<Process> sortedProcesses = new List<Process>();

            /* looping on all check times */
            for (int i = 0; i < checkTimes.Count; i++)
            {
                /* each process started in this check time is Added to list */
                foreach (Process process in processes)
                {
                    if (process.arrivalTime == checkTimes[i])
                    {
                        sortedProcesses.Add(process);
                    }
                }

                /* Sorting the processes based on Priority then based on the Arrival Time (handle if there are 2 process has the same priority) */
                sortedProcesses = sortedProcesses.OrderBy(p => p.priority).ThenBy(p => p.arrivalTime).ToList();

                /* We dont need to continue with same logic if its the last check point */
                if (i == checkTimes.Count - 1)
                    break;
                /*Case we have an idle slot(Processes arrive in next check time) but the previous process remaining time was less than the difference between two consecutives check times*/
                if (sortedProcesses.Count == 0)
                {
                    continue;
                }
                /* Dequeing first process from the list */
                Process pMaxPriority = sortedProcesses[0];
                sortedProcesses.RemoveAt(0);

                /* Condition to insert a new check point if current process can be completely finished in time less than difference between 2 check times */
                if (pMaxPriority.remainingTime < checkTimes[i + 1] - checkTimes[i])
                {
                    checkTimes.Insert(i + 1, pMaxPriority.remainingTime + checkTimes[i]);
                }
                pMaxPriority.remainingTime = pMaxPriority.remainingTime - (checkTimes[i + 1] - checkTimes[i]);

                /* We need to requeue the process if still got remaining time */
                if (pMaxPriority.remainingTime > 0)
                {
                    sortedProcesses.Add(pMaxPriority);
                }

                /* Creating a gantt block of processed process */
                ganttBlocks.Add(new GanttBlock(pMaxPriority.name, checkTimes[i], checkTimes[i + 1]));
            }

            /* Now we have passed all check points in Time(check times) and accordingly we just keep dequeuing and processing according to prio */
            /*last check time*/
            float time = checkTimes[checkTimes.Count - 1];
            while (sortedProcesses.Count > 0)
            {
                /* Dequing first process from the list */
                Process p = sortedProcesses[0];
                sortedProcesses.RemoveAt(0);

                ganttBlocks.Add(new GanttBlock(p.name, time, time + p.remainingTime));

                time = time + p.remainingTime;/* To keep up with our timeline */
                p.remainingTime = 0;/* Setting Remaining time of process to 0 as finished */
            }


            /* Calculation for waiting time and turn around time */
            foreach (var process in processes)
            {
                /* Finds a list of all gantt blocks containing process name to find start and departure time */
                var matchedList = ganttBlocks.FindAll(delegate (GanttBlock p)
                {
                    return p.name == process.name;
                });

                totaTurnAroundTime += matchedList[matchedList.Count - 1].endTime - process.arrivalTime;
                totaWaitingTime += matchedList[matchedList.Count - 1].endTime - process.arrivalTime - process.burstTime;
            }

            /* Merge adjacent Gantt blocks with the same name */
            List<GanttBlock> toDrawBlocks = new List<GanttBlock>();
            for (int i = 0; i < ganttBlocks.Count; i++)
            {
                float start = ganttBlocks[i].startTime;
                float end = ganttBlocks[i].endTime;
                while ((i < ganttBlocks.Count - 1) && (ganttBlocks[i + 1].name == ganttBlocks[i].name))
                {
                    i++;
                    end = ganttBlocks[i].endTime;
                }
                toDrawBlocks.Add(new GanttBlock(ganttBlocks[i].name, start, end));
            }

            return (totaWaitingTime / processes.Count, totaTurnAroundTime / processes.Count, toDrawBlocks);
        }
    }
}
