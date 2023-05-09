namespace Scheduler_Assignment
{
    partial class RRDataWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Burst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.quantumButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeToRoundRobinSchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillInTheTextBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitEnterToInsertTheDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onceDoneHitDrawAndSeeTheMagicHappenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hitBackIfYouWantToChangeSchedulingOrChangeNumberOfProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hopeYouFindItUsefulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Burst time";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(191, 91);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(125, 38);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertButton.Location = new System.Drawing.Point(191, 175);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(125, 46);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.Arrival,
            this.Burst});
            this.dataGridView1.Location = new System.Drawing.Point(358, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(430, 291);
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
            this.backButton.Location = new System.Drawing.Point(23, 365);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(139, 50);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // drawButton
            // 
            this.drawButton.Enabled = false;
            this.drawButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.drawButton.Location = new System.Drawing.Point(405, 365);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(137, 50);
            this.drawButton.TabIndex = 8;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantum";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Location = new System.Drawing.Point(191, 271);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(125, 37);
            this.richTextBox3.TabIndex = 10;
            this.richTextBox3.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // quantumButton
            // 
            this.quantumButton.Enabled = false;
            this.quantumButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantumButton.Location = new System.Drawing.Point(191, 365);
            this.quantumButton.Name = "quantumButton";
            this.quantumButton.Size = new System.Drawing.Size(137, 50);
            this.quantumButton.TabIndex = 11;
            this.quantumButton.Text = "Enter quantum";
            this.quantumButton.UseVisualStyleBackColor = true;
            this.quantumButton.Click += new System.EventHandler(this.quantumButton_Click_1);
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
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeToRoundRobinSchedulingToolStripMenuItem,
            this.fillInTheTextBoxesToolStripMenuItem,
            this.hitEnterToInsertTheDataToolStripMenuItem,
            this.onceDoneHitDrawAndSeeTheMagicHappenToolStripMenuItem,
            this.hitBackIfYouWantToChangeSchedulingOrChangeNumberOfProcessesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // welcomeToRoundRobinSchedulingToolStripMenuItem
            // 
            this.welcomeToRoundRobinSchedulingToolStripMenuItem.Name = "welcomeToRoundRobinSchedulingToolStripMenuItem";
            this.welcomeToRoundRobinSchedulingToolStripMenuItem.Size = new System.Drawing.Size(582, 26);
            this.welcomeToRoundRobinSchedulingToolStripMenuItem.Text = "Welcome to Round Robin  Scheduling";
            // 
            // fillInTheTextBoxesToolStripMenuItem
            // 
            this.fillInTheTextBoxesToolStripMenuItem.Name = "fillInTheTextBoxesToolStripMenuItem";
            this.fillInTheTextBoxesToolStripMenuItem.Size = new System.Drawing.Size(582, 26);
            this.fillInTheTextBoxesToolStripMenuItem.Text = "Fill in the Text boxes";
            // 
            // hitEnterToInsertTheDataToolStripMenuItem
            // 
            this.hitEnterToInsertTheDataToolStripMenuItem.Name = "hitEnterToInsertTheDataToolStripMenuItem";
            this.hitEnterToInsertTheDataToolStripMenuItem.Size = new System.Drawing.Size(582, 26);
            this.hitEnterToInsertTheDataToolStripMenuItem.Text = "Hit Enter to insert the data";
            // 
            // onceDoneHitDrawAndSeeTheMagicHappenToolStripMenuItem
            // 
            this.onceDoneHitDrawAndSeeTheMagicHappenToolStripMenuItem.Name = "onceDoneHitDrawAndSeeTheMagicHappenToolStripMenuItem";
            this.onceDoneHitDrawAndSeeTheMagicHappenToolStripMenuItem.Size = new System.Drawing.Size(582, 26);
            this.onceDoneHitDrawAndSeeTheMagicHappenToolStripMenuItem.Text = "Once done hit Draw and see the Magic happen";
            // 
            // hitBackIfYouWantToChangeSchedulingOrChangeNumberOfProcessesToolStripMenuItem
            // 
            this.hitBackIfYouWantToChangeSchedulingOrChangeNumberOfProcessesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.hitBackIfYouWantToChangeSchedulingOrChangeNumberOfProcessesToolStripMenuItem.Name = "hitBackIfYouWantToChangeSchedulingOrChangeNumberOfProcessesToolStripMenuItem";
            this.hitBackIfYouWantToChangeSchedulingOrChangeNumberOfProcessesToolStripMenuItem.Size = new System.Drawing.Size(582, 26);
            this.hitBackIfYouWantToChangeSchedulingOrChangeNumberOfProcessesToolStripMenuItem.Text = "Hit back if you want to change Scheduling or change number of processes";
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
            this.theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem,
            this.zToolStripMenuItem,
            this.hopeYouFindItUsefulToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // thisGUIIsMadeByJumanaEmadToolStripMenuItem
            // 
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem.Name = "thisGUIIsMadeByJumanaEmadToolStripMenuItem";
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem.Size = new System.Drawing.Size(735, 26);
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem.Text = "This GUI is made by Jumana Emad ";
            // 
            // theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem
            // 
            this.theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem.Name = "theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStrip" +
    "MenuItem";
            this.theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem.Size = new System.Drawing.Size(735, 26);
            this.theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem.Text = "The Functionalties are made by : Heba Mahmoud , Monica Adel , Marina Milad and Ma" +
    "rtina Samy";
            // 
            // zToolStripMenuItem
            // 
            this.zToolStripMenuItem.Name = "zToolStripMenuItem";
            this.zToolStripMenuItem.Size = new System.Drawing.Size(735, 26);
            this.zToolStripMenuItem.Text = "z";
            // 
            // hopeYouFindItUsefulToolStripMenuItem
            // 
            this.hopeYouFindItUsefulToolStripMenuItem.Name = "hopeYouFindItUsefulToolStripMenuItem";
            this.hopeYouFindItUsefulToolStripMenuItem.Size = new System.Drawing.Size(735, 26);
            this.hopeYouFindItUsefulToolStripMenuItem.Text = "Hope you find it useful";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(616, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 66);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dynamic Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // RRDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quantumButton);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RRDataWindow";
            this.Text = "Round Robin Scheduling";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private RichTextBox richTextBox2;
        private Button insertButton;
        private DataGridView dataGridView1;
        private Button backButton;
        private Button drawButton;
        private Label label3;
        private RichTextBox richTextBox3;
        private ErrorProvider errorProvider1;
        private Button quantumButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem thisGUIIsMadeByJumanaEmadToolStripMenuItem;
        private ToolStripMenuItem zToolStripMenuItem;
        private ToolStripMenuItem theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem;
        private ToolStripMenuItem hopeYouFindItUsefulToolStripMenuItem;
        private ToolStripMenuItem welcomeToRoundRobinSchedulingToolStripMenuItem;
        private ToolStripMenuItem fillInTheTextBoxesToolStripMenuItem;
        private ToolStripMenuItem hitEnterToInsertTheDataToolStripMenuItem;
        private ToolStripMenuItem onceDoneHitDrawAndSeeTheMagicHappenToolStripMenuItem;
        private ToolStripMenuItem hitBackIfYouWantToChangeSchedulingOrChangeNumberOfProcessesToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private DataGridViewTextBoxColumn PName;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Burst;
        private Button button1;
    }
}