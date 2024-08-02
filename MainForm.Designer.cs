namespace Assignment_7
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonFinishWorkout = new Button();
            buttonAddUser = new Button();
            groupBoxUser = new GroupBox();
            comboBoxUnit = new ComboBox();
            label1 = new Label();
            labelGoals = new Label();
            textBoxDeadliftGoal = new TextBox();
            textBoxBenchGoal = new TextBox();
            textBoxSquatGoal = new TextBox();
            textBoxBodyWeight = new TextBox();
            textBoxUsername = new TextBox();
            labelDeadlift = new Label();
            labelUsername = new Label();
            labelBench = new Label();
            labelSquat = new Label();
            labelBodyWeight = new Label();
            buttonStartWorkout = new Button();
            listBox1 = new ListBox();
            groupBoxWorkout = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxExercise = new ComboBox();
            buttonChangeRep = new Button();
            buttonDeleteRep = new Button();
            textBoxWeight = new TextBox();
            labelWeight = new Label();
            buttonAddRep = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newWorkoutToolStripMenuItem = new ToolStripMenuItem();
            saveWorkoutToolStripMenuItem = new ToolStripMenuItem();
            openWorkoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            groupBoxUser.SuspendLayout();
            groupBoxWorkout.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonFinishWorkout
            // 
            buttonFinishWorkout.Location = new Point(739, 492);
            buttonFinishWorkout.Name = "buttonFinishWorkout";
            buttonFinishWorkout.Size = new Size(174, 59);
            buttonFinishWorkout.TabIndex = 0;
            buttonFinishWorkout.Text = "Finish workout";
            buttonFinishWorkout.UseVisualStyleBackColor = true;
            buttonFinishWorkout.Click += buttonFinishWorkout_Click_1;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(15, 406);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(362, 34);
            buttonAddUser.TabIndex = 1;
            buttonAddUser.Text = "Add user";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // groupBoxUser
            // 
            groupBoxUser.Controls.Add(comboBoxUnit);
            groupBoxUser.Controls.Add(label1);
            groupBoxUser.Controls.Add(labelGoals);
            groupBoxUser.Controls.Add(textBoxDeadliftGoal);
            groupBoxUser.Controls.Add(textBoxBenchGoal);
            groupBoxUser.Controls.Add(textBoxSquatGoal);
            groupBoxUser.Controls.Add(textBoxBodyWeight);
            groupBoxUser.Controls.Add(textBoxUsername);
            groupBoxUser.Controls.Add(labelDeadlift);
            groupBoxUser.Controls.Add(labelUsername);
            groupBoxUser.Controls.Add(labelBench);
            groupBoxUser.Controls.Add(buttonAddUser);
            groupBoxUser.Controls.Add(labelSquat);
            groupBoxUser.Controls.Add(labelBodyWeight);
            groupBoxUser.Location = new Point(12, 45);
            groupBoxUser.Name = "groupBoxUser";
            groupBoxUser.Size = new Size(394, 449);
            groupBoxUser.TabIndex = 2;
            groupBoxUser.TabStop = false;
            groupBoxUser.Text = "User profile";
            // 
            // comboBoxUnit
            // 
            comboBoxUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnit.FormattingEnabled = true;
            comboBoxUnit.Location = new Point(250, 196);
            comboBoxUnit.Name = "comboBoxUnit";
            comboBoxUnit.Size = new Size(127, 33);
            comboBoxUnit.TabIndex = 8;
            // 
            // label1
            // 
            label1.Location = new Point(15, 199);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 8;
            label1.Text = "Choose unit";
            // 
            // labelGoals
            // 
            labelGoals.Location = new Point(15, 138);
            labelGoals.Name = "labelGoals";
            labelGoals.Size = new Size(362, 25);
            labelGoals.TabIndex = 14;
            labelGoals.Text = "My weightlifting goals:";
            labelGoals.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxDeadliftGoal
            // 
            textBoxDeadliftGoal.Location = new Point(250, 346);
            textBoxDeadliftGoal.Name = "textBoxDeadliftGoal";
            textBoxDeadliftGoal.Size = new Size(127, 31);
            textBoxDeadliftGoal.TabIndex = 12;
            // 
            // textBoxBenchGoal
            // 
            textBoxBenchGoal.Location = new Point(250, 297);
            textBoxBenchGoal.Name = "textBoxBenchGoal";
            textBoxBenchGoal.Size = new Size(127, 31);
            textBoxBenchGoal.TabIndex = 11;
            // 
            // textBoxSquatGoal
            // 
            textBoxSquatGoal.Location = new Point(250, 249);
            textBoxSquatGoal.Name = "textBoxSquatGoal";
            textBoxSquatGoal.Size = new Size(127, 31);
            textBoxSquatGoal.TabIndex = 10;
            // 
            // textBoxBodyWeight
            // 
            textBoxBodyWeight.Location = new Point(140, 77);
            textBoxBodyWeight.Name = "textBoxBodyWeight";
            textBoxBodyWeight.Size = new Size(237, 31);
            textBoxBodyWeight.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(140, 35);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(237, 31);
            textBoxUsername.TabIndex = 8;
            // 
            // labelDeadlift
            // 
            labelDeadlift.Location = new Point(15, 352);
            labelDeadlift.Name = "labelDeadlift";
            labelDeadlift.Size = new Size(122, 25);
            labelDeadlift.TabIndex = 7;
            labelDeadlift.Text = "Deadlift";
            // 
            // labelUsername
            // 
            labelUsername.Location = new Point(15, 41);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(114, 25);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // labelBench
            // 
            labelBench.Location = new Point(15, 303);
            labelBench.Name = "labelBench";
            labelBench.Size = new Size(59, 25);
            labelBench.TabIndex = 6;
            labelBench.Text = "Bench";
            // 
            // labelSquat
            // 
            labelSquat.Location = new Point(15, 252);
            labelSquat.Name = "labelSquat";
            labelSquat.Size = new Size(59, 25);
            labelSquat.TabIndex = 5;
            labelSquat.Text = "Squat";
            // 
            // labelBodyWeight
            // 
            labelBodyWeight.Location = new Point(15, 83);
            labelBodyWeight.Name = "labelBodyWeight";
            labelBodyWeight.Size = new Size(76, 25);
            labelBodyWeight.TabIndex = 3;
            labelBodyWeight.Text = "Weight";
            // 
            // buttonStartWorkout
            // 
            buttonStartWorkout.Location = new Point(152, 500);
            buttonStartWorkout.Name = "buttonStartWorkout";
            buttonStartWorkout.Size = new Size(112, 107);
            buttonStartWorkout.TabIndex = 3;
            buttonStartWorkout.Text = "Start workout";
            buttonStartWorkout.UseVisualStyleBackColor = true;
            buttonStartWorkout.Click += buttonStartWorkout_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(6, 142);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(907, 334);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBoxWorkout
            // 
            groupBoxWorkout.Controls.Add(label2);
            groupBoxWorkout.Controls.Add(label3);
            groupBoxWorkout.Controls.Add(comboBoxExercise);
            groupBoxWorkout.Controls.Add(buttonChangeRep);
            groupBoxWorkout.Controls.Add(buttonDeleteRep);
            groupBoxWorkout.Controls.Add(textBoxWeight);
            groupBoxWorkout.Controls.Add(labelWeight);
            groupBoxWorkout.Controls.Add(buttonAddRep);
            groupBoxWorkout.Controls.Add(listBox1);
            groupBoxWorkout.Controls.Add(buttonFinishWorkout);
            groupBoxWorkout.Location = new Point(429, 25);
            groupBoxWorkout.Name = "groupBoxWorkout";
            groupBoxWorkout.Size = new Size(919, 557);
            groupBoxWorkout.TabIndex = 5;
            groupBoxWorkout.TabStop = false;
            groupBoxWorkout.Text = "Workout";
            // 
            // label2
            // 
            label2.Location = new Point(175, 114);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 15;
            label2.Text = "Exercise";
            // 
            // label3
            // 
            label3.Location = new Point(602, 114);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 9;
            label3.Text = "Weight, KG";
            // 
            // comboBoxExercise
            // 
            comboBoxExercise.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxExercise.FormattingEnabled = true;
            comboBoxExercise.Location = new Point(74, 58);
            comboBoxExercise.Name = "comboBoxExercise";
            comboBoxExercise.Size = new Size(250, 33);
            comboBoxExercise.TabIndex = 8;
            // 
            // buttonChangeRep
            // 
            buttonChangeRep.Location = new Point(37, 504);
            buttonChangeRep.Name = "buttonChangeRep";
            buttonChangeRep.Size = new Size(112, 34);
            buttonChangeRep.TabIndex = 6;
            buttonChangeRep.Text = "Change rep";
            buttonChangeRep.UseVisualStyleBackColor = true;
            buttonChangeRep.Click += buttonChangeRep_Click;
            // 
            // buttonDeleteRep
            // 
            buttonDeleteRep.Location = new Point(175, 504);
            buttonDeleteRep.Name = "buttonDeleteRep";
            buttonDeleteRep.Size = new Size(112, 34);
            buttonDeleteRep.TabIndex = 7;
            buttonDeleteRep.Text = "Delete rep";
            buttonDeleteRep.UseVisualStyleBackColor = true;
            buttonDeleteRep.Click += buttonDeleteRep_Click;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(515, 58);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(117, 31);
            textBoxWeight.TabIndex = 7;
            // 
            // labelWeight
            // 
            labelWeight.Location = new Point(409, 61);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(87, 29);
            labelWeight.TabIndex = 6;
            labelWeight.Text = "Weight";
            // 
            // buttonAddRep
            // 
            buttonAddRep.Location = new Point(664, 56);
            buttonAddRep.Name = "buttonAddRep";
            buttonAddRep.Size = new Size(231, 34);
            buttonAddRep.TabIndex = 4;
            buttonAddRep.Text = "Add rep";
            buttonAddRep.UseVisualStyleBackColor = true;
            buttonAddRep.Click += buttonAddRep_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1360, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newWorkoutToolStripMenuItem, saveWorkoutToolStripMenuItem, openWorkoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newWorkoutToolStripMenuItem
            // 
            newWorkoutToolStripMenuItem.Name = "newWorkoutToolStripMenuItem";
            newWorkoutToolStripMenuItem.Size = new Size(229, 34);
            newWorkoutToolStripMenuItem.Text = "New workout";
            newWorkoutToolStripMenuItem.Click += newWorkoutToolStripMenuItem_Click;
            // 
            // saveWorkoutToolStripMenuItem
            // 
            saveWorkoutToolStripMenuItem.Name = "saveWorkoutToolStripMenuItem";
            saveWorkoutToolStripMenuItem.Size = new Size(229, 34);
            saveWorkoutToolStripMenuItem.Text = "Save workout";
            saveWorkoutToolStripMenuItem.Click += saveWorkoutToolStripMenuItem_Click;
            // 
            // openWorkoutToolStripMenuItem
            // 
            openWorkoutToolStripMenuItem.Name = "openWorkoutToolStripMenuItem";
            openWorkoutToolStripMenuItem.Size = new Size(229, 34);
            openWorkoutToolStripMenuItem.Text = "Open workout";
            openWorkoutToolStripMenuItem.Click += openWorkoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(229, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 619);
            Controls.Add(groupBoxWorkout);
            Controls.Add(buttonStartWorkout);
            Controls.Add(groupBoxUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "My Workout Application by Ida Modigh";
            groupBoxUser.ResumeLayout(false);
            groupBoxUser.PerformLayout();
            groupBoxWorkout.ResumeLayout(false);
            groupBoxWorkout.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFinishWorkout;
        private Button buttonAddUser;
        private GroupBox groupBoxUser;
        private Label labelDeadlift;
        private Label labelUsername;
        private Label labelBench;
        private Label labelSquat;
        private Label labelBodyWeight;
        private Button buttonStartWorkout;
        private TextBox textBoxDeadliftGoal;
        private TextBox textBoxBenchGoal;
        private TextBox textBoxSquatGoal;
        private TextBox textBoxBodyWeight;
        private TextBox textBoxUsername;
        private Label labelGoals;
        private ListBox listBox1;
        private GroupBox groupBoxWorkout;
        private Button buttonAddRep;
        private Label labelWeight;
        private TextBox textBoxWeight;
        private Button buttonChangeRep;
        private Button buttonDeleteRep;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newWorkoutToolStripMenuItem;
        private ToolStripMenuItem saveWorkoutToolStripMenuItem;
        private ToolStripMenuItem openWorkoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ComboBox comboBoxUnit;
        private ComboBox comboBoxExercise;
        private Label label2;
        private Label label3;
    }
}