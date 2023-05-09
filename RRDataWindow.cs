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
    public partial class RRDataWindow : Form
    {
        private int processesNumber;
        private int insertedNumber = 0;
        private float quantum;
        private float averageWaiting;
        private float averageTurnaround;
        private MainWindow mainWindow;
        private List<Process> processList = new List<Process>();
        private List<GanttBlock> ganttBlocks = new List<GanttBlock>();

        public RRDataWindow(int number, MainWindow main)
        {
            InitializeComponent();
            processesNumber = number;
            mainWindow = main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            float arrivalTime, burstTime;
            if (!float.TryParse(richTextBox2.Text, out float result2))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label2, "Please enter a valid number");
            }
            else
            {
                burstTime = float.Parse(richTextBox2.Text);
                if (burstTime <= 0)
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(label2, "Burst time must be positive");
                }
                else
                {
                    errorProvider1.Clear();
                    insertedNumber++;
                    if (insertedNumber == processesNumber)
                    {
                        insertButton.Enabled = false;
                        richTextBox3.Enabled = true;
                        quantumButton.Enabled = true;
                    }
                    Process p = new Process(0, burstTime);
                    processList.Add(p);
                    string[] row = { p.name, p.arrivalTime.ToString(), p.burstTime.ToString() };
                    dataGridView1.Rows.Add(row);
                    richTextBox2.Clear();
                }
            }
        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        private void quantumButton_Click_1(object sender, EventArgs e)
        {
            if (!float.TryParse(richTextBox3.Text, out float result))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label3, "Please enter a valid number");
            }
            else
            {
                quantum = float.Parse(richTextBox3.Text);
                if (quantum <= 0)
                {
                    errorProvider1.SetError(label3, "Quantum must be positive");
                }
                else
                {
                    drawButton.Enabled = true;
                }
            }
        }

        private void drawButton_Click_1(object sender, EventArgs e)
        {
            (averageWaiting, averageTurnaround, ganttBlocks) = RoundRobin.roundRobin(processList, quantum);
            Form f1 = new GanttVisualizer(ganttBlocks, averageWaiting, averageTurnaround, mainWindow);
            Close();
            f1.Show();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            (averageWaiting, averageTurnaround, ganttBlocks) = RoundRobin.roundRobin(processList, quantum);
            Form f1 = new Form2(processList, ganttBlocks, averageWaiting, averageTurnaround, mainWindow);
            Close();
            f1.Show();
        }

    }
}
