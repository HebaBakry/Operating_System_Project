namespace Scheduler_Assignment
{
    public partial class MainWindow : Form
    {
        public string Type = ""; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selectButton_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(richTextBox1.Text, out int result))
            {
                errorProvider1.SetError(label1, "Please enter a valid number");
            }
            else if (int.Parse(richTextBox1.Text) <= 0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label1, "Number of processes must be positive");
            }
            else if (comboBox1.SelectedItem == null)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(label2, "Please select an algorithm");
            }
            else
            {
                errorProvider1.Clear();
                Form dataWindow;
                if (comboBox1.Text == "FCFS" || comboBox1.Text == "SJF (Non-Preemptive)" || comboBox1.Text == "SJF (Preemptive)")
                {
                    if (comboBox1.Text == "FCFS") dataWindow = new BasicDataWindow(int.Parse(richTextBox1.Text), this, 0);
                    else if (comboBox1.Text == "SJF (Non-Preemptive)") dataWindow = new BasicDataWindow(int.Parse(richTextBox1.Text), this, 1);
                    else dataWindow = new BasicDataWindow(int.Parse(richTextBox1.Text), this, 2);
                }
                else if (comboBox1.Text == "Round Robin")
                {
                    dataWindow = new RRDataWindow(int.Parse(richTextBox1.Text), this);
                }
                else if (comboBox1.Text == "Priority (Non-Preemptive)") {
                    dataWindow = new PriorityDataWindow(int.Parse(richTextBox1.Text), this, 0);
                }
                else
                {
                    dataWindow = new PriorityDataWindow(int.Parse(richTextBox1.Text), this, 1);
                }
                Type = comboBox1.Text;
                Process.count = 0;
                dataWindow.Show();
                this.Hide();
            }
        }


    }
}