namespace Scheduler_Assignment
{
    partial class BasicDataWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Burst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeToSchedulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillInTheEmptyTextBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitInsertAfterEveryProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onceDoneWithAllProcessesHitTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ifYouWantToChangeSchedulerTypeOrChangeProcessesNumberHitBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theFunctionalitiesAreMadeByHebaMhmoudMarinaMiladMonicaAdelAndMartinaSamyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hopeYouFindItUsefulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arrival time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Burst time";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(186, 70);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(125, 37);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(186, 192);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(125, 39);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertButton.Location = new System.Drawing.Point(310, 351);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(122, 47);
            this.insertButton.TabIndex = 5;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Arrival,
            this.Burst});
            this.dataGridView1.Location = new System.Drawing.Point(348, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(440, 271);
            this.dataGridView1.TabIndex = 6;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PName.DefaultCellStyle = dataGridViewCellStyle1;
            this.PName.HeaderText = "Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Arrival
            // 
            this.Arrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Arrival.DefaultCellStyle = dataGridViewCellStyle2;
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            // 
            // Burst
            // 
            this.Burst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Burst.DefaultCellStyle = dataGridViewCellStyle3;
            this.Burst.HeaderText = "Burst";
            this.Burst.MinimumWidth = 6;
            this.Burst.Name = "Burst";
            this.Burst.ReadOnly = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(105, 351);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(115, 47);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // drawButton
            // 
            this.drawButton.Enabled = false;
            this.drawButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.drawButton.Location = new System.Drawing.Point(514, 350);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(121, 48);
            this.drawButton.TabIndex = 8;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToSchedulerToolStripMenuItem,
            this.fillInTheEmptyTextBoxesToolStripMenuItem,
            this.hitInsertAfterEveryProcessToolStripMenuItem,
            this.onceDoneWithAllProcessesHitTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem,
            this.ifYouWantToChangeSchedulerTypeOrChangeProcessesNumberHitBackToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // welcomeToSchedulerToolStripMenuItem
            // 
            this.welcomeToSchedulerToolStripMenuItem.Name = "welcomeToSchedulerToolStripMenuItem";
            this.welcomeToSchedulerToolStripMenuItem.Size = new System.Drawing.Size(614, 26);
            this.welcomeToSchedulerToolStripMenuItem.Text = "Welcome to Scheduler";
            // 
            // fillInTheEmptyTextBoxesToolStripMenuItem
            // 
            this.fillInTheEmptyTextBoxesToolStripMenuItem.Name = "fillInTheEmptyTextBoxesToolStripMenuItem";
            this.fillInTheEmptyTextBoxesToolStripMenuItem.Size = new System.Drawing.Size(614, 26);
            this.fillInTheEmptyTextBoxesToolStripMenuItem.Text = "Fill in the Empty Text Boxes ";
            // 
            // hitInsertAfterEveryProcessToolStripMenuItem
            // 
            this.hitInsertAfterEveryProcessToolStripMenuItem.Name = "hitInsertAfterEveryProcessToolStripMenuItem";
            this.hitInsertAfterEveryProcessToolStripMenuItem.Size = new System.Drawing.Size(614, 26);
            this.hitInsertAfterEveryProcessToolStripMenuItem.Text = "Hit insert after every process ";
            // 
            // onceDoneWithAllProcessesHitTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem
            // 
            this.onceDoneWithAllProcessesHitTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem.Name = "onceDoneWithAllProcessesHitTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem";
            this.onceDoneWithAllProcessesHitTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem.Size = new System.Drawing.Size(614, 26);
            this.onceDoneWithAllProcessesHitTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem.Text = "Once done with all processes Hit the draw Button and watch the magic happen";
            // 
            // ifYouWantToChangeSchedulerTypeOrChangeProcessesNumberHitBackToolStripMenuItem
            // 
            this.ifYouWantToChangeSchedulerTypeOrChangeProcessesNumberHitBackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.ifYouWantToChangeSchedulerTypeOrChangeProcessesNumberHitBackToolStripMenuItem.Name = "ifYouWantToChangeSchedulerTypeOrChangeProcessesNumberHitBackToolStripMenuItem";
            this.ifYouWantToChangeSchedulerTypeOrChangeProcessesNumberHitBackToolStripMenuItem.Size = new System.Drawing.Size(614, 26);
            this.ifYouWantToChangeSchedulerTypeOrChangeProcessesNumberHitBackToolStripMenuItem.Text = "If you want to change scheduler type or change processes number hit Back";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem,
            this.theFunctionalitiesAreMadeByHebaMhmoudMarinaMiladMonicaAdelAndMartinaSamyToolStripMenuItem,
            this.hopeYouFindItUsefulToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // thisGUIIsMadeByJumanaEmadToolStripMenuItem
            // 
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem.Name = "thisGUIIsMadeByJumanaEmadToolStripMenuItem";
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem.Size = new System.Drawing.Size(724, 26);
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem.Text = "This GUI is made By Jumana Emad";
            // 
            // theFunctionalitiesAreMadeByHebaMhmoudMarinaMiladMonicaAdelAndMartinaSamyToolStripMenuItem
            // 
            this.theFunctionalitiesAreMadeByHebaMhmoudMarinaMiladMonicaAdelAndMartinaSamyToolStripMenuItem.Name = "theFunctionalitiesAreMadeByHebaMhmoudMarinaMiladMonicaAdelAndMartinaSamyToolStrip" +
    "MenuItem";
            this.theFunctionalitiesAreMadeByHebaMhmoudMarinaMiladMonicaAdelAndMartinaSamyToolStripMenuItem.Size = new System.Drawing.Size(724, 26);
            this.theFunctionalitiesAreMadeByHebaMhmoudMarinaMiladMonicaAdelAndMartinaSamyToolStripMenuItem.Text = "The Functionalities are made by Heba Mahmoud, Marina Milad, Monica Adel and Marti" +
    "na Samy";
            // 
            // hopeYouFindItUsefulToolStripMenuItem
            // 
            this.hopeYouFindItUsefulToolStripMenuItem.Name = "hopeYouFindItUsefulToolStripMenuItem";
            this.hopeYouFindItUsefulToolStripMenuItem.Size = new System.Drawing.Size(724, 26);
            this.hopeYouFindItUsefulToolStripMenuItem.Text = "Hope you find it Useful";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(668, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dynamic Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BasicDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BasicDataWindow";
            this.Text = "Sheduler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button insertButton;
        private DataGridView dataGridView1;
        private Button backButton;
        private Button drawButton;
        private ErrorProvider errorProvider1;
        private DataGridViewTextBoxColumn PName;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Burst;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem welcomeToSchedulerToolStripMenuItem;
        private ToolStripMenuItem fillInTheEmptyTextBoxesToolStripMenuItem;
        private ToolStripMenuItem hitInsertAfterEveryProcessToolStripMenuItem;
        private ToolStripMenuItem onceDoneWithAllProcessesHitTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem;
        private ToolStripMenuItem ifYouWantToChangeSchedulerTypeOrChangeProcessesNumberHitBackToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem thisGUIIsMadeByJumanaEmadToolStripMenuItem;
        private ToolStripMenuItem theFunctionalitiesAreMadeByHebaMhmoudMarinaMiladMonicaAdelAndMartinaSamyToolStripMenuItem;
        private ToolStripMenuItem hopeYouFindItUsefulToolStripMenuItem;
        private Button button1;
    }
}