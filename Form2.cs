using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler_Assignment
{
    public partial class Form2 : Form
    {
        const int minBoxwidth = 300;    //Not implemented yet
        public List<Rectangle> rects = new List<Rectangle>();
        public List<Process> processList;
        public List<Process> modprocessList = new List<Process>();
        public List<GanttBlock> blocks;
        private Form mainWindow;
        private bool drawn = false;
        private string type;
        private float averageWaiting;
        private float averageTurnaround;
        private float mkani;
        private List<GanttBlock> ganttBlocks = new List<GanttBlock>();
        public Form2(List<Process> processList, List<GanttBlock> blocks, float averageWaitingTime, float averageTurnaroundTime, MainWindow mainWindow)
        {
            this.blocks = blocks;
            this.mainWindow = mainWindow;
            this.processList = processList;
            this.type = mainWindow.Type;

            InitializeComponent();
            label1.Text = "Average waiting time: " + averageWaitingTime;
            label2.Text = "Average turnaround time: " + averageTurnaroundTime;


        }
        private void WaitNSeconds(int sec)
        {
            if (sec < 1) { return; }
            DateTime desired = DateTime.Now.AddSeconds(sec);
            while (DateTime.Now < desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
        private List<GanttBlock> idleFiller(List<GanttBlock> gList)
        {
            List<GanttBlock> result = new List<GanttBlock>();
            for (int i = 0; i < gList.Count - 1; i++)
            {
                result.Add(gList[i]);
                if (gList[i].endTime != gList[i + 1].startTime)
                {
                    result.Add(new GanttBlock("Idle", gList[i].endTime, gList[i + 1].startTime, gList[i].remainingTime));
                }
            }
            result.Add(gList[gList.Count - 1]);
            return result;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string message, title, default_value;
            object myvalue;
            message = "Please add arrival and burst and (Optional) piriority in This form arrival,burst,priority\nNote that if no priority is given for priority scheduling\nIt is treated as priority 1";

            title = "Add Process";
            //default_value = "2,1";

            myvalue = Interaction.InputBox(message, title);

            float arrivalTime, burstTime;
            int priority;
            if (myvalue != "")
            {
                string[] word = (myvalue.ToString()).Split(',');
                arrivalTime = float.Parse(word[0]);
                burstTime = float.Parse(word[1]);
                if (word.Count() > 2)
                {
                    priority = int.Parse(word[2]);
                }
                else
                {
                    priority = 1;
                }
                if (arrivalTime >= mkani || type == "Round Robin")
                {
                    Process p = new Process(arrivalTime, burstTime, priority);
                    foreach (Process process in processList)
                    {
                        modprocessList.Add(process);
                        process.remainingTime = process.burstTime;
                    }
                    for (int l = 0; l < modprocessList.Count; l++)
                    {
                        if ((type != "SJF (Preemptive)") && (type != "Priority (Preemptive)"))
                        {
                            if (modprocessList[l].arrivalTime >= p.arrivalTime)
                            {
                                modprocessList[l].remainingTime = modprocessList[l].burstTime;
                            }
                        }
                        else
                        {

                            foreach (GanttBlock block in blocks)
                            {
                                if (block.endTime < p.arrivalTime)
                                {
                                    foreach (Process pro in processList)
                                    {
                                        if (block.name == pro.name)
                                        {
                                            //pro.remainingTime -= (block.endTime - block.startTime);
                                        }
                                    }
                                }
                                else
                                {
                                    modprocessList[l].remainingTime = modprocessList[l].burstTime;
                                }

                            }
                        }

                        modprocessList[l].endTime = null;
                        modprocessList[l].inQueue = false;
                    }

                    modprocessList.Add(p);

                    if (type == "FCFS") (averageWaiting, averageTurnaround, ganttBlocks) = FCFS.FCFS_Schedule(modprocessList);
                    else if (type == "SJF (Non-Preemptive)") (averageWaiting, averageTurnaround, ganttBlocks) = SJFNonPreemptive.SJFNon(modprocessList);
                    else if (type == "SJF (Preemptive)") (averageWaiting, averageTurnaround, ganttBlocks) = SJFPreemptive.SJFP(modprocessList);
                    else if (type == "Round Robin")
                    {
                        float quanta = RoundRobin.qua;
                        foreach (Process process in modprocessList)
                        {
                            process.arrivalTime = 0;
                        }
                        (averageWaiting, averageTurnaround, ganttBlocks) = RoundRobin.roundRobin(modprocessList, quanta);
                    }
                    else if (type == "Priority (Non-Preemptive)") (averageWaiting, averageTurnaround, ganttBlocks) = PriorityNonPreemptive.Priority_NP(modprocessList);
                    else (averageWaiting, averageTurnaround, ganttBlocks) = PriorityPreemptive.Priority_P(modprocessList);

                    label1.Text = "Average Waiting: " + averageWaiting;
                    label2.Text = "Average TurnAround: " + averageTurnaround;
                    List<GanttBlock> gList = idleFiller(ganttBlocks);
                    this.blocks = gList;
                    this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
                }
                else
                {
                    MessageBox.Show("Invalid Arrival Time, Must be greater than or equal " + mkani);
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics; //Call
    
            this.WindowState = FormWindowState.Maximized;
            int startingWidth = 100;

            blocks = idleFiller(blocks);
            float totalTime = blocks[blocks.Count - 1].endTime;
            float unitWidth = 1000 / totalTime;
            float blockTime = 0;
            int blockWidth = 0;
            int idle = 0;

            string[] row;
            List<string> proc = new List<string>();
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush b = new SolidBrush(Color.White);
            Brush purple = new SolidBrush(Color.Purple);
            g.DrawString(blocks[0].startTime.ToString(), Font, blackBrush, new Point(startingWidth, 350)); // To be changed



            for (int i = 0; i < blocks.Count; i++)//Gantt blocks
            {
                Rectangle rect = new Rectangle();
                blockTime = blocks[i].endTime - blocks[i].startTime;
                blockWidth = (int)(unitWidth * blockTime + 0.99);

                mkani = blocks[i].endTime;



                if (blocks[i].name != "Idle" && (!(proc.Contains(blocks[i].name))))
                {
                    proc.Add(blocks[i].name);
                    row = new string[] { blocks[i].name, blocks[i].remainingTime.ToString() };
                    dataGridView1.Rows.Add(row);

                }


                rect.Size = new Size(blockWidth, 50);  //Function in time

                rect.X = startingWidth;
                rect.Y = 300;
                if (!drawn)
                    rects.Add(rect);

                startingWidth += blockWidth;//Depends on the time

                Rectangle r = rects[i];
                Point labelPoint = new Point(r.X + (r.Width / 2), r.Y + 10);

                Pen p = new Pen(Color.Navy, 4);


                g.DrawRectangle(p, r);
                g.DrawString(blocks[i].name, Font, b, labelPoint);


                WaitNSeconds((int)blockTime);
                g.DrawString(blocks[i].endTime.ToString(), Font, blackBrush, new Point(startingWidth, 350));

                //dataGridView1.UpdateCellValue(1,0);
                if (blocks[i].name != "Idle")
                {
                    foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                    {
                        if (dataGridViewRow.Cells["Process"].Value.ToString() == blocks[i].name)
                        {
                            DataGridViewCell cell = dataGridViewRow.Cells["Remaining_Time"];
                            cell.Value = (float.Parse(cell.Value.ToString()) - blockTime).ToString();
                            dataGridView1.Refresh();
                            break;
                        }
                    }
                }
            }
            drawn = true;



        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
