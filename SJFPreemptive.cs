using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler_Assignment
{
    internal class SJFPreemptive
    {
        public static (float, float, List<GanttBlock>) SJFP(List<Process> processes)
        {
            float totaWaitingTime = 0, totaTurnAroundTime = 0;
            List<GanttBlock> ganttBlocks = new List<GanttBlock>();

            /* A list of all Arrival times To keep track of our check points in time */
            List<float> arrTime = new List<float>();
            foreach (Process process in processes)
            {
                arrTime.Add(process.arrivalTime);
            }

            /* Sorting the check points */
            arrTime.Sort();
            arrTime = arrTime.Distinct().ToList();
            List<Process> sortedProcesses = new List<Process>();
            for (int i = 0; i < arrTime.Count; i++)
            {
                foreach (Process process in processes)
                {
                    if (process.arrivalTime == arrTime[i])
                    {
                        sortedProcesses.Add(process);
                    }
                }
                sortedProcesses = sortedProcesses.OrderBy(p => p.remainingTime).ThenBy(p => p.arrivalTime).ToList();
                if (i == arrTime.Count - 1)
                    break;
                if (sortedProcesses.Count == 0)
                {
                    continue;
                }
                Process pMaxPriority = sortedProcesses[0];
                sortedProcesses.RemoveAt(0);
                if (pMaxPriority.remainingTime < arrTime[i + 1] - arrTime[i])
                {
                    arrTime.Insert(i + 1, pMaxPriority.remainingTime + arrTime[i]);
                }
                pMaxPriority.remainingTime = pMaxPriority.remainingTime - (arrTime[i + 1] - arrTime[i]);
                if (pMaxPriority.remainingTime > 0)
                {
                    sortedProcesses.Add(pMaxPriority);
                }
                ganttBlocks.Add(new GanttBlock(pMaxPriority.name, arrTime[i], arrTime[i + 1], pMaxPriority.burstTime));
            }
            float time = arrTime[arrTime.Count - 1];
            while (sortedProcesses.Count > 0)
            {
                Process p = sortedProcesses[0];
                sortedProcesses.RemoveAt(0);
                ganttBlocks.Add(new GanttBlock(p.name, time, time + p.remainingTime, p.burstTime));

                time = time + p.remainingTime;
                p.remainingTime = 0;
            }
            foreach (var process in processes)
            {
                var matchedList = ganttBlocks.FindAll(delegate (GanttBlock p)
                {
                    return p.name == process.name;
                });

                totaTurnAroundTime += matchedList[matchedList.Count - 1].endTime - process.arrivalTime;
                totaWaitingTime += matchedList[matchedList.Count - 1].endTime - process.arrivalTime - process.burstTime;
            }
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
                toDrawBlocks.Add(new GanttBlock(ganttBlocks[i].name, start, end, ganttBlocks[i].remainingTime));
            }

            return (totaWaitingTime / processes.Count, totaTurnAroundTime / processes.Count, toDrawBlocks);
        }

    }
}
