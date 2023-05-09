namespace Scheduler_Assignment
{

    /*
     * 1- Did not add turnaround and waiting time yet 
     * 
     * 
     */
    public partial class GanttVisualizer : Form
    {
        const int minBoxwidth = 300;    //Not implemented yet
        public List<Rectangle> rects = new List<Rectangle>();

        public List<GanttBlock> blocks;
        private Form mainWindow;
        private bool drawn = false;

        public GanttVisualizer(List<GanttBlock> blocks, float averageWaitingTime, float averageTurnaroundTime, Form mainWindow)
        {
            this.blocks = blocks;
            this.mainWindow = mainWindow;
            InitializeComponent();
            label1.Text = "Average waiting time: " + averageWaitingTime;
            label2.Text = "Average turnaround time: " + averageTurnaroundTime;
        }

        //Function for filling the gaps between blocks with idle blocks in case of non proceeding blocks.
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; //Call
            /*
             * Example 
             * 
             * blocks = new List<GanttBlock
             * blocks.Add(new GanttBlock("P1", 0, 2
             * blocks.Add(new GanttBlock("P2", 3, 5
             * blocks.Add(new GanttBlock("P3", 5, 6
             * blocks.Add(new GanttBlock("P4", 6, 10));
             * blocks.Add(new GanttBlock("P5", 10, 12));
            */
            int startingWidth = 100;
            blocks = idleFiller(blocks);
            float totalTime = blocks[blocks.Count - 1].endTime;
            float unitWidth = 1200 / totalTime;
            Brush blackBrush = new SolidBrush(Color.Black);
            g.DrawString(blocks[0].startTime.ToString(), Font, blackBrush, new Point(startingWidth, 350)); // To be changed
            for (int i = 0; i < blocks.Count; i++)//Gantt blocks
            {
                Rectangle rect = new Rectangle();
                float blockTime = blocks[i].endTime - blocks[i].startTime;
                int blockWidth = (int)(unitWidth * blockTime + 0.99);
                rect.Size = new Size(blockWidth, 50);  //Function in time

                rect.X = startingWidth;
                rect.Y = 300;
                if (!drawn)
                    rects.Add(rect);

                startingWidth += blockWidth;//Depends on the time
                g.DrawString(blocks[i].endTime.ToString(), Font, blackBrush, new Point(startingWidth, 350));

            }
            Brush b = new SolidBrush(Color.Black);

            for (int i = 0; i < rects.Count; i++)
            {
                Rectangle r = rects[i];
                Point labelPoint = new Point(r.X + (r.Width / 2), r.Y + 10);
                g.DrawString(blocks[i].name, Font, b, labelPoint);
                Pen p = new Pen(Color.Blue);
                g.DrawRectangle(p, r);
            }
            drawn = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainWindow.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
