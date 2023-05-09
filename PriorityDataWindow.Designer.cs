namespace Scheduler_Assignment
{
    partial class PriorityDataWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Burst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thisIsTheGUIForPrioritySchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pleaseFillInTheEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pressInsertAfterEnteringTheDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteThatYouWillBeAbleToFillInTheNumberYouInsertedInTheLastScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ifYouWishToRestartTheWholeThisPleaseHitBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afterCompletionYouCanPressTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hopeYouFindItUsefulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arrival time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Burst time";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(186, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(125, 37);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(186, 144);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(125, 38);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertButton.Location = new System.Drawing.Point(270, 362);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(119, 54);
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
            this.Burst,
            this.Priority});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(331, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(446, 271);
            this.dataGridView1.TabIndex = 6;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            this.PName.DefaultCellStyle = dataGridViewCellStyle1;
            this.PName.HeaderText = "Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Arrival
            // 
            this.Arrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Burst.DefaultCellStyle = dataGridViewCellStyle3;
            this.Burst.HeaderText = "Burst";
            this.Burst.MinimumWidth = 6;
            this.Burst.Name = "Burst";
            this.Burst.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Priority.DefaultCellStyle = dataGridViewCellStyle4;
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(33, 362);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(128, 54);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // drawButton
            // 
            this.drawButton.Enabled = false;
            this.drawButton.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.drawButton.Location = new System.Drawing.Point(471, 362);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(118, 54);
            this.drawButton.TabIndex = 8;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Priority";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(186, 239);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(125, 39);
            this.richTextBox3.TabIndex = 10;
            this.richTextBox3.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisIsTheGUIForPrioritySchedulingToolStripMenuItem,
            this.pleaseFillInTheEmptyToolStripMenuItem,
            this.pressInsertAfterEnteringTheDataToolStripMenuItem,
            this.noteThatYouWillBeAbleToFillInTheNumberYouInsertedInTheLastScreenToolStripMenuItem,
            this.ifYouWishToRestartTheWholeThisPleaseHitBackToolStripMenuItem,
            this.afterCompletionYouCanPressTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // thisIsTheGUIForPrioritySchedulingToolStripMenuItem
            // 
            this.thisIsTheGUIForPrioritySchedulingToolStripMenuItem.Name = "thisIsTheGUIForPrioritySchedulingToolStripMenuItem";
            this.thisIsTheGUIForPrioritySchedulingToolStripMenuItem.Size = new System.Drawing.Size(608, 26);
            this.thisIsTheGUIForPrioritySchedulingToolStripMenuItem.Text = "Welcome to Priority scheduling";
            // 
            // pleaseFillInTheEmptyToolStripMenuItem
            // 
            this.pleaseFillInTheEmptyToolStripMenuItem.Name = "pleaseFillInTheEmptyToolStripMenuItem";
            this.pleaseFillInTheEmptyToolStripMenuItem.Size = new System.Drawing.Size(608, 26);
            this.pleaseFillInTheEmptyToolStripMenuItem.Text = "Please fill in the empty textboxes";
            // 
            // pressInsertAfterEnteringTheDataToolStripMenuItem
            // 
            this.pressInsertAfterEnteringTheDataToolStripMenuItem.Name = "pressInsertAfterEnteringTheDataToolStripMenuItem";
            this.pressInsertAfterEnteringTheDataToolStripMenuItem.Size = new System.Drawing.Size(608, 26);
            this.pressInsertAfterEnteringTheDataToolStripMenuItem.Text = "Press insert after entering the data";
            // 
            // noteThatYouWillBeAbleToFillInTheNumberYouInsertedInTheLastScreenToolStripMenuItem
            // 
            this.noteThatYouWillBeAbleToFillInTheNumberYouInsertedInTheLastScreenToolStripMenuItem.Name = "noteThatYouWillBeAbleToFillInTheNumberYouInsertedInTheLastScreenToolStripMenuItem" +
    "";
            this.noteThatYouWillBeAbleToFillInTheNumberYouInsertedInTheLastScreenToolStripMenuItem.Size = new System.Drawing.Size(608, 26);
            this.noteThatYouWillBeAbleToFillInTheNumberYouInsertedInTheLastScreenToolStripMenuItem.Text = "Note that You will be able to fill in the number you inserted in the last screen";
            // 
            // ifYouWishToRestartTheWholeThisPleaseHitBackToolStripMenuItem
            // 
            this.ifYouWishToRestartTheWholeThisPleaseHitBackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.ifYouWishToRestartTheWholeThisPleaseHitBackToolStripMenuItem.Name = "ifYouWishToRestartTheWholeThisPleaseHitBackToolStripMenuItem";
            this.ifYouWishToRestartTheWholeThisPleaseHitBackToolStripMenuItem.Size = new System.Drawing.Size(608, 26);
            this.ifYouWishToRestartTheWholeThisPleaseHitBackToolStripMenuItem.Text = "If you wish to go back to change please click on Back";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // afterCompletionYouCanPressTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem
            // 
            this.afterCompletionYouCanPressTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem.Name = "afterCompletionYouCanPressTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem";
            this.afterCompletionYouCanPressTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem.Size = new System.Drawing.Size(608, 26);
            this.afterCompletionYouCanPressTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem.Text = "After Completion you can press the Draw Button and watch the magic happen";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisGUIIsMadeByJumanaEmadToolStripMenuItem,
            this.theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem,
            this.hopeYouFindItUsefulToolStripMenuItem});
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem1.Text = "About";
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
            // hopeYouFindItUsefulToolStripMenuItem
            // 
            this.hopeYouFindItUsefulToolStripMenuItem.Name = "hopeYouFindItUsefulToolStripMenuItem";
            this.hopeYouFindItUsefulToolStripMenuItem.Size = new System.Drawing.Size(735, 26);
            this.hopeYouFindItUsefulToolStripMenuItem.Text = "Hope you find it useful";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(657, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dynamic Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PriorityDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.label3);
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
            this.Name = "PriorityDataWindow";
            this.Text = "Priority Scheduling";
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
        private Label label3;
        private RichTextBox richTextBox3;
        private ErrorProvider errorProvider1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem thisIsTheGUIForPrioritySchedulingToolStripMenuItem;
        private ToolStripMenuItem pleaseFillInTheEmptyToolStripMenuItem;
        private ToolStripMenuItem pressInsertAfterEnteringTheDataToolStripMenuItem;
        private ToolStripMenuItem noteThatYouWillBeAbleToFillInTheNumberYouInsertedInTheLastScreenToolStripMenuItem;
        private ToolStripMenuItem ifYouWishToRestartTheWholeThisPleaseHitBackToolStripMenuItem;
        private ToolStripMenuItem afterCompletionYouCanPressTheDrawButtonAndWatchTheMagicHappenToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem thisGUIIsMadeByJumanaEmadToolStripMenuItem;
        private ToolStripMenuItem theFunctionaltiesAreMadeByHebaMahmoudMonicaAdelMarinaMiladAndMartinaSamyToolStripMenuItem;
        private ToolStripMenuItem hopeYouFindItUsefulToolStripMenuItem;
        private ToolStripMenuItem backToolStripMenuItem;
        private DataGridViewTextBoxColumn PName;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Burst;
        private DataGridViewTextBoxColumn Priority;
        private Button button1;
    }
}