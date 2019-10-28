namespace Edsac
{
    partial class MainForm
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
            this.tapeInput = new System.Windows.Forms.TextBox();
            this.printerOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.countBox = new System.Windows.Forms.TextBox();
            this.stepButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.showMultiply = new System.Windows.Forms.CheckBox();
            this.showAccumulator = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.showOrder = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.showScr = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.scrTube = new System.Windows.Forms.PictureBox();
            this.accumulatorTube = new System.Windows.Forms.PictureBox();
            this.orderTube = new System.Windows.Forms.PictureBox();
            this.multiplyTube = new System.Windows.Forms.PictureBox();
            this.longTankTube = new System.Windows.Forms.PictureBox();
            this.tankSelector = new System.Windows.Forms.ComboBox();
            this.dial3 = new System.Windows.Forms.Button();
            this.dial6 = new System.Windows.Forms.Button();
            this.dial0 = new System.Windows.Forms.Button();
            this.dial2 = new System.Windows.Forms.Button();
            this.dial5 = new System.Windows.Forms.Button();
            this.dial9 = new System.Windows.Forms.Button();
            this.dial1 = new System.Windows.Forms.Button();
            this.dial4 = new System.Windows.Forms.Button();
            this.dial8 = new System.Windows.Forms.Button();
            this.dial7 = new System.Windows.Forms.Button();
            this.clearOutputButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.traceEnabled = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newBreakpoint = new System.Windows.Forms.TextBox();
            this.newBreakpointButton = new System.Windows.Forms.Button();
            this.deleteBreakpointButton = new System.Windows.Forms.Button();
            this.breakpoints = new System.Windows.Forms.ListBox();
            this.nextInstruction = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearTraceButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trace = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.memAddress = new System.Windows.Forms.TextBox();
            this.memAddressButton = new System.Windows.Forms.Button();
            this.memRefreshButton = new System.Windows.Forms.Button();
            this.memNextButton = new System.Windows.Forms.Button();
            this.memPrevButton = new System.Windows.Forms.Button();
            this.memScrButton = new System.Windows.Forms.Button();
            this.memoryDump = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.disRefreshButton = new System.Windows.Forms.Button();
            this.disPrevButton = new System.Windows.Forms.Button();
            this.disNextButton = new System.Windows.Forms.Button();
            this.disAddressButton = new System.Windows.Forms.Button();
            this.disFrom = new System.Windows.Forms.TextBox();
            this.disCsrButton = new System.Windows.Forms.Button();
            this.disassembly = new System.Windows.Forms.TextBox();
            this.stoppedLabel = new System.Windows.Forms.Label();
            this.runningLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.ordersSelect = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.scrOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accumulatorTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyTube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longTankTube)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tapeInput
            // 
            this.tapeInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tapeInput.Location = new System.Drawing.Point(12, 16);
            this.tapeInput.Multiline = true;
            this.tapeInput.Name = "tapeInput";
            this.tapeInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tapeInput.Size = new System.Drawing.Size(907, 454);
            this.tapeInput.TabIndex = 0;
            this.tapeInput.WordWrap = false;
            // 
            // printerOutput
            // 
            this.printerOutput.AcceptsReturn = true;
            this.printerOutput.AcceptsTab = true;
            this.printerOutput.BackColor = System.Drawing.Color.White;
            this.printerOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printerOutput.Location = new System.Drawing.Point(732, 24);
            this.printerOutput.Multiline = true;
            this.printerOutput.Name = "printerOutput";
            this.printerOutput.ReadOnly = true;
            this.printerOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.printerOutput.Size = new System.Drawing.Size(434, 190);
            this.printerOutput.TabIndex = 1;
            this.printerOutput.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(729, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Printer Output";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(174, 527);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(93, 527);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(255, 527);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // countBox
            // 
            this.countBox.Location = new System.Drawing.Point(919, 532);
            this.countBox.Name = "countBox";
            this.countBox.Size = new System.Drawing.Size(100, 20);
            this.countBox.TabIndex = 8;
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(336, 527);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 9;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1190, 509);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.showMultiply);
            this.tabPage1.Controls.Add(this.showAccumulator);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.showOrder);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.showScr);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.scrTube);
            this.tabPage1.Controls.Add(this.accumulatorTube);
            this.tabPage1.Controls.Add(this.orderTube);
            this.tabPage1.Controls.Add(this.multiplyTube);
            this.tabPage1.Controls.Add(this.longTankTube);
            this.tabPage1.Controls.Add(this.tankSelector);
            this.tabPage1.Controls.Add(this.dial3);
            this.tabPage1.Controls.Add(this.dial6);
            this.tabPage1.Controls.Add(this.dial0);
            this.tabPage1.Controls.Add(this.dial2);
            this.tabPage1.Controls.Add(this.dial5);
            this.tabPage1.Controls.Add(this.dial9);
            this.tabPage1.Controls.Add(this.dial1);
            this.tabPage1.Controls.Add(this.dial4);
            this.tabPage1.Controls.Add(this.dial8);
            this.tabPage1.Controls.Add(this.dial7);
            this.tabPage1.Controls.Add(this.clearOutputButton);
            this.tabPage1.Controls.Add(this.printerOutput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1182, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Multiplier/Multiplicand";
            // 
            // showMultiply
            // 
            this.showMultiply.AutoSize = true;
            this.showMultiply.Checked = true;
            this.showMultiply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMultiply.Location = new System.Drawing.Point(121, 221);
            this.showMultiply.Name = "showMultiply";
            this.showMultiply.Size = new System.Drawing.Size(15, 14);
            this.showMultiply.TabIndex = 28;
            this.showMultiply.UseVisualStyleBackColor = true;
            // 
            // showAccumulator
            // 
            this.showAccumulator.AutoSize = true;
            this.showAccumulator.Checked = true;
            this.showAccumulator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAccumulator.Location = new System.Drawing.Point(352, 220);
            this.showAccumulator.Name = "showAccumulator";
            this.showAccumulator.Size = new System.Drawing.Size(15, 14);
            this.showAccumulator.TabIndex = 27;
            this.showAccumulator.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Accumulator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Order";
            // 
            // showOrder
            // 
            this.showOrder.AutoSize = true;
            this.showOrder.Checked = true;
            this.showOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOrder.Location = new System.Drawing.Point(585, 221);
            this.showOrder.Name = "showOrder";
            this.showOrder.Size = new System.Drawing.Size(15, 14);
            this.showOrder.TabIndex = 24;
            this.showOrder.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Long Tank";
            // 
            // showScr
            // 
            this.showScr.AutoSize = true;
            this.showScr.Checked = true;
            this.showScr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showScr.Location = new System.Drawing.Point(585, 462);
            this.showScr.Name = "showScr";
            this.showScr.Size = new System.Drawing.Size(15, 14);
            this.showScr.TabIndex = 22;
            this.showScr.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "SCR";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(925, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // scrTube
            // 
            this.scrTube.BackColor = System.Drawing.Color.Black;
            this.scrTube.Location = new System.Drawing.Point(478, 244);
            this.scrTube.Name = "scrTube";
            this.scrTube.Size = new System.Drawing.Size(230, 212);
            this.scrTube.TabIndex = 19;
            this.scrTube.TabStop = false;
            // 
            // accumulatorTube
            // 
            this.accumulatorTube.BackColor = System.Drawing.Color.Black;
            this.accumulatorTube.Location = new System.Drawing.Point(242, 6);
            this.accumulatorTube.Name = "accumulatorTube";
            this.accumulatorTube.Size = new System.Drawing.Size(230, 212);
            this.accumulatorTube.TabIndex = 19;
            this.accumulatorTube.TabStop = false;
            // 
            // orderTube
            // 
            this.orderTube.BackColor = System.Drawing.Color.Black;
            this.orderTube.Location = new System.Drawing.Point(478, 6);
            this.orderTube.Name = "orderTube";
            this.orderTube.Size = new System.Drawing.Size(230, 212);
            this.orderTube.TabIndex = 19;
            this.orderTube.TabStop = false;
            // 
            // multiplyTube
            // 
            this.multiplyTube.BackColor = System.Drawing.Color.Black;
            this.multiplyTube.Location = new System.Drawing.Point(6, 6);
            this.multiplyTube.Name = "multiplyTube";
            this.multiplyTube.Size = new System.Drawing.Size(230, 212);
            this.multiplyTube.TabIndex = 19;
            this.multiplyTube.TabStop = false;
            // 
            // longTankTube
            // 
            this.longTankTube.BackColor = System.Drawing.Color.Black;
            this.longTankTube.Location = new System.Drawing.Point(242, 244);
            this.longTankTube.Name = "longTankTube";
            this.longTankTube.Size = new System.Drawing.Size(230, 212);
            this.longTankTube.TabIndex = 19;
            this.longTankTube.TabStop = false;
            // 
            // tankSelector
            // 
            this.tankSelector.FormattingEnabled = true;
            this.tankSelector.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.tankSelector.Location = new System.Drawing.Point(319, 462);
            this.tankSelector.Name = "tankSelector";
            this.tankSelector.Size = new System.Drawing.Size(72, 21);
            this.tankSelector.TabIndex = 16;
            this.tankSelector.SelectedIndexChanged += new System.EventHandler(this.tankSelector_SelectedIndexChanged);
            // 
            // dial3
            // 
            this.dial3.Location = new System.Drawing.Point(969, 416);
            this.dial3.Name = "dial3";
            this.dial3.Size = new System.Drawing.Size(24, 24);
            this.dial3.TabIndex = 15;
            this.dial3.Text = "3";
            this.dial3.UseVisualStyleBackColor = true;
            this.dial3.Click += new System.EventHandler(this.dial3_Click);
            // 
            // dial6
            // 
            this.dial6.Location = new System.Drawing.Point(969, 386);
            this.dial6.Name = "dial6";
            this.dial6.Size = new System.Drawing.Size(24, 24);
            this.dial6.TabIndex = 15;
            this.dial6.Text = "6";
            this.dial6.UseVisualStyleBackColor = true;
            this.dial6.Click += new System.EventHandler(this.dial6_Click);
            // 
            // dial0
            // 
            this.dial0.Location = new System.Drawing.Point(939, 446);
            this.dial0.Name = "dial0";
            this.dial0.Size = new System.Drawing.Size(24, 24);
            this.dial0.TabIndex = 15;
            this.dial0.Text = "0";
            this.dial0.UseVisualStyleBackColor = true;
            this.dial0.Click += new System.EventHandler(this.dial0_Click);
            // 
            // dial2
            // 
            this.dial2.Location = new System.Drawing.Point(939, 416);
            this.dial2.Name = "dial2";
            this.dial2.Size = new System.Drawing.Size(24, 24);
            this.dial2.TabIndex = 15;
            this.dial2.Text = "2";
            this.dial2.UseVisualStyleBackColor = true;
            this.dial2.Click += new System.EventHandler(this.dial2_Click);
            // 
            // dial5
            // 
            this.dial5.Location = new System.Drawing.Point(939, 386);
            this.dial5.Name = "dial5";
            this.dial5.Size = new System.Drawing.Size(24, 24);
            this.dial5.TabIndex = 15;
            this.dial5.Text = "5";
            this.dial5.UseVisualStyleBackColor = true;
            this.dial5.Click += new System.EventHandler(this.dial5_Click);
            // 
            // dial9
            // 
            this.dial9.Location = new System.Drawing.Point(969, 356);
            this.dial9.Name = "dial9";
            this.dial9.Size = new System.Drawing.Size(24, 24);
            this.dial9.TabIndex = 15;
            this.dial9.Text = "9";
            this.dial9.UseVisualStyleBackColor = true;
            this.dial9.Click += new System.EventHandler(this.dial9_Click);
            // 
            // dial1
            // 
            this.dial1.Location = new System.Drawing.Point(909, 416);
            this.dial1.Name = "dial1";
            this.dial1.Size = new System.Drawing.Size(24, 24);
            this.dial1.TabIndex = 15;
            this.dial1.Text = "1";
            this.dial1.UseVisualStyleBackColor = true;
            this.dial1.Click += new System.EventHandler(this.dial1_Click);
            // 
            // dial4
            // 
            this.dial4.Location = new System.Drawing.Point(909, 386);
            this.dial4.Name = "dial4";
            this.dial4.Size = new System.Drawing.Size(24, 24);
            this.dial4.TabIndex = 15;
            this.dial4.Text = "4";
            this.dial4.UseVisualStyleBackColor = true;
            this.dial4.Click += new System.EventHandler(this.dial4_Click);
            // 
            // dial8
            // 
            this.dial8.Location = new System.Drawing.Point(939, 356);
            this.dial8.Name = "dial8";
            this.dial8.Size = new System.Drawing.Size(24, 24);
            this.dial8.TabIndex = 15;
            this.dial8.Text = "8";
            this.dial8.UseVisualStyleBackColor = true;
            this.dial8.Click += new System.EventHandler(this.dial8_Click);
            // 
            // dial7
            // 
            this.dial7.Location = new System.Drawing.Point(909, 356);
            this.dial7.Name = "dial7";
            this.dial7.Size = new System.Drawing.Size(24, 24);
            this.dial7.TabIndex = 15;
            this.dial7.Text = "7";
            this.dial7.UseVisualStyleBackColor = true;
            this.dial7.Click += new System.EventHandler(this.dial7_Click);
            // 
            // clearOutputButton
            // 
            this.clearOutputButton.Location = new System.Drawing.Point(925, 220);
            this.clearOutputButton.Name = "clearOutputButton";
            this.clearOutputButton.Size = new System.Drawing.Size(75, 23);
            this.clearOutputButton.TabIndex = 10;
            this.clearOutputButton.Text = "Clear Output";
            this.clearOutputButton.UseVisualStyleBackColor = true;
            this.clearOutputButton.Click += new System.EventHandler(this.clearOutputButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tapeInput);
            this.tabPage4.Controls.Add(this.loadButton);
            this.tabPage4.Controls.Add(this.saveButton);
            this.tabPage4.Controls.Add(this.newButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1182, 483);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tape Input";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(925, 16);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(925, 45);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(925, 447);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 13;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.traceEnabled);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.nextInstruction);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.clearTraceButton);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.trace);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1182, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // traceEnabled
            // 
            this.traceEnabled.AutoSize = true;
            this.traceEnabled.Location = new System.Drawing.Point(24, 398);
            this.traceEnabled.Name = "traceEnabled";
            this.traceEnabled.Size = new System.Drawing.Size(90, 17);
            this.traceEnabled.TabIndex = 13;
            this.traceEnabled.Text = "Enable Trace";
            this.traceEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newBreakpoint);
            this.groupBox1.Controls.Add(this.newBreakpointButton);
            this.groupBox1.Controls.Add(this.deleteBreakpointButton);
            this.groupBox1.Controls.Add(this.breakpoints);
            this.groupBox1.Location = new System.Drawing.Point(17, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 303);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Breakpoints";
            // 
            // newBreakpoint
            // 
            this.newBreakpoint.Location = new System.Drawing.Point(12, 277);
            this.newBreakpoint.Name = "newBreakpoint";
            this.newBreakpoint.Size = new System.Drawing.Size(172, 20);
            this.newBreakpoint.TabIndex = 3;
            // 
            // newBreakpointButton
            // 
            this.newBreakpointButton.Location = new System.Drawing.Point(190, 275);
            this.newBreakpointButton.Name = "newBreakpointButton";
            this.newBreakpointButton.Size = new System.Drawing.Size(75, 23);
            this.newBreakpointButton.TabIndex = 2;
            this.newBreakpointButton.Text = "Add";
            this.newBreakpointButton.UseVisualStyleBackColor = true;
            this.newBreakpointButton.Click += new System.EventHandler(this.newBreakpointButton_Click);
            // 
            // deleteBreakpointButton
            // 
            this.deleteBreakpointButton.Location = new System.Drawing.Point(94, 240);
            this.deleteBreakpointButton.Name = "deleteBreakpointButton";
            this.deleteBreakpointButton.Size = new System.Drawing.Size(75, 23);
            this.deleteBreakpointButton.TabIndex = 1;
            this.deleteBreakpointButton.Text = "Delete";
            this.deleteBreakpointButton.UseVisualStyleBackColor = true;
            this.deleteBreakpointButton.Click += new System.EventHandler(this.deleteBreakpointButton_Click);
            // 
            // breakpoints
            // 
            this.breakpoints.FormattingEnabled = true;
            this.breakpoints.Location = new System.Drawing.Point(12, 22);
            this.breakpoints.Name = "breakpoints";
            this.breakpoints.Size = new System.Drawing.Size(253, 212);
            this.breakpoints.Sorted = true;
            this.breakpoints.TabIndex = 0;
            // 
            // nextInstruction
            // 
            this.nextInstruction.BackColor = System.Drawing.Color.White;
            this.nextInstruction.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextInstruction.Location = new System.Drawing.Point(111, 352);
            this.nextInstruction.Name = "nextInstruction";
            this.nextInstruction.ReadOnly = true;
            this.nextInstruction.Size = new System.Drawing.Size(126, 20);
            this.nextInstruction.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Next Instruction:";
            // 
            // clearTraceButton
            // 
            this.clearTraceButton.Location = new System.Drawing.Point(233, 394);
            this.clearTraceButton.Name = "clearTraceButton";
            this.clearTraceButton.Size = new System.Drawing.Size(75, 23);
            this.clearTraceButton.TabIndex = 2;
            this.clearTraceButton.Text = "Clear Trace";
            this.clearTraceButton.UseVisualStyleBackColor = true;
            this.clearTraceButton.Click += new System.EventHandler(this.clearTraceButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trace";
            // 
            // trace
            // 
            this.trace.BackColor = System.Drawing.Color.White;
            this.trace.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trace.Location = new System.Drawing.Point(314, 27);
            this.trace.Multiline = true;
            this.trace.Name = "trace";
            this.trace.ReadOnly = true;
            this.trace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.trace.Size = new System.Drawing.Size(681, 390);
            this.trace.TabIndex = 0;
            this.trace.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1182, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Memory";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.memAddress);
            this.groupBox3.Controls.Add(this.memAddressButton);
            this.groupBox3.Controls.Add(this.memRefreshButton);
            this.groupBox3.Controls.Add(this.memNextButton);
            this.groupBox3.Controls.Add(this.memPrevButton);
            this.groupBox3.Controls.Add(this.memScrButton);
            this.groupBox3.Controls.Add(this.memoryDump);
            this.groupBox3.Location = new System.Drawing.Point(315, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(681, 457);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memory";
            // 
            // memAddress
            // 
            this.memAddress.Location = new System.Drawing.Point(8, 65);
            this.memAddress.Name = "memAddress";
            this.memAddress.Size = new System.Drawing.Size(73, 20);
            this.memAddress.TabIndex = 6;
            // 
            // memAddressButton
            // 
            this.memAddressButton.Location = new System.Drawing.Point(8, 91);
            this.memAddressButton.Name = "memAddressButton";
            this.memAddressButton.Size = new System.Drawing.Size(73, 23);
            this.memAddressButton.TabIndex = 5;
            this.memAddressButton.Text = "Address";
            this.memAddressButton.UseVisualStyleBackColor = true;
            this.memAddressButton.Click += new System.EventHandler(this.memAddressButton_Click);
            // 
            // memRefreshButton
            // 
            this.memRefreshButton.Location = new System.Drawing.Point(6, 234);
            this.memRefreshButton.Name = "memRefreshButton";
            this.memRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.memRefreshButton.TabIndex = 4;
            this.memRefreshButton.Text = "Refresh";
            this.memRefreshButton.UseVisualStyleBackColor = true;
            this.memRefreshButton.Click += new System.EventHandler(this.memRefreshButton_Click);
            // 
            // memNextButton
            // 
            this.memNextButton.Location = new System.Drawing.Point(6, 423);
            this.memNextButton.Name = "memNextButton";
            this.memNextButton.Size = new System.Drawing.Size(75, 23);
            this.memNextButton.TabIndex = 3;
            this.memNextButton.Text = "Next";
            this.memNextButton.UseVisualStyleBackColor = true;
            this.memNextButton.Click += new System.EventHandler(this.memNextButton_Click);
            // 
            // memPrevButton
            // 
            this.memPrevButton.Location = new System.Drawing.Point(6, 394);
            this.memPrevButton.Name = "memPrevButton";
            this.memPrevButton.Size = new System.Drawing.Size(75, 23);
            this.memPrevButton.TabIndex = 2;
            this.memPrevButton.Text = "Previous";
            this.memPrevButton.UseVisualStyleBackColor = true;
            this.memPrevButton.Click += new System.EventHandler(this.memPrevButton_Click);
            // 
            // memScrButton
            // 
            this.memScrButton.Location = new System.Drawing.Point(6, 19);
            this.memScrButton.Name = "memScrButton";
            this.memScrButton.Size = new System.Drawing.Size(75, 23);
            this.memScrButton.TabIndex = 1;
            this.memScrButton.Text = "SCR";
            this.memScrButton.UseVisualStyleBackColor = true;
            this.memScrButton.Click += new System.EventHandler(this.memScrButton_Click);
            // 
            // memoryDump
            // 
            this.memoryDump.BackColor = System.Drawing.Color.White;
            this.memoryDump.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryDump.Location = new System.Drawing.Point(89, 19);
            this.memoryDump.Multiline = true;
            this.memoryDump.Name = "memoryDump";
            this.memoryDump.ReadOnly = true;
            this.memoryDump.Size = new System.Drawing.Size(586, 427);
            this.memoryDump.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.disRefreshButton);
            this.groupBox2.Controls.Add(this.disPrevButton);
            this.groupBox2.Controls.Add(this.disNextButton);
            this.groupBox2.Controls.Add(this.disAddressButton);
            this.groupBox2.Controls.Add(this.disFrom);
            this.groupBox2.Controls.Add(this.disCsrButton);
            this.groupBox2.Controls.Add(this.disassembly);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 458);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Disassembly";
            // 
            // disRefreshButton
            // 
            this.disRefreshButton.Location = new System.Drawing.Point(195, 234);
            this.disRefreshButton.Name = "disRefreshButton";
            this.disRefreshButton.Size = new System.Drawing.Size(75, 23);
            this.disRefreshButton.TabIndex = 6;
            this.disRefreshButton.Text = "Refresh";
            this.disRefreshButton.UseVisualStyleBackColor = true;
            this.disRefreshButton.Click += new System.EventHandler(this.disRefreshButton_Click);
            // 
            // disPrevButton
            // 
            this.disPrevButton.Location = new System.Drawing.Point(195, 394);
            this.disPrevButton.Name = "disPrevButton";
            this.disPrevButton.Size = new System.Drawing.Size(75, 23);
            this.disPrevButton.TabIndex = 5;
            this.disPrevButton.Text = "Previous";
            this.disPrevButton.UseVisualStyleBackColor = true;
            this.disPrevButton.Click += new System.EventHandler(this.disPrevButton_Click);
            // 
            // disNextButton
            // 
            this.disNextButton.Location = new System.Drawing.Point(195, 423);
            this.disNextButton.Name = "disNextButton";
            this.disNextButton.Size = new System.Drawing.Size(75, 23);
            this.disNextButton.TabIndex = 4;
            this.disNextButton.Text = "Next";
            this.disNextButton.UseVisualStyleBackColor = true;
            this.disNextButton.Click += new System.EventHandler(this.disNextButton_Click);
            // 
            // disAddressButton
            // 
            this.disAddressButton.Location = new System.Drawing.Point(195, 91);
            this.disAddressButton.Name = "disAddressButton";
            this.disAddressButton.Size = new System.Drawing.Size(75, 23);
            this.disAddressButton.TabIndex = 3;
            this.disAddressButton.Text = "Address";
            this.disAddressButton.UseVisualStyleBackColor = true;
            this.disAddressButton.Click += new System.EventHandler(this.disAddressButton_Click);
            // 
            // disFrom
            // 
            this.disFrom.Location = new System.Drawing.Point(195, 65);
            this.disFrom.Name = "disFrom";
            this.disFrom.Size = new System.Drawing.Size(75, 20);
            this.disFrom.TabIndex = 2;
            // 
            // disCsrButton
            // 
            this.disCsrButton.Location = new System.Drawing.Point(195, 19);
            this.disCsrButton.Name = "disCsrButton";
            this.disCsrButton.Size = new System.Drawing.Size(75, 23);
            this.disCsrButton.TabIndex = 1;
            this.disCsrButton.Text = "SCR";
            this.disCsrButton.UseVisualStyleBackColor = true;
            this.disCsrButton.Click += new System.EventHandler(this.disCsrButton_Click);
            // 
            // disassembly
            // 
            this.disassembly.BackColor = System.Drawing.Color.White;
            this.disassembly.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disassembly.Location = new System.Drawing.Point(10, 19);
            this.disassembly.Multiline = true;
            this.disassembly.Name = "disassembly";
            this.disassembly.ReadOnly = true;
            this.disassembly.Size = new System.Drawing.Size(179, 427);
            this.disassembly.TabIndex = 0;
            // 
            // stoppedLabel
            // 
            this.stoppedLabel.AutoSize = true;
            this.stoppedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoppedLabel.ForeColor = System.Drawing.Color.Red;
            this.stoppedLabel.Location = new System.Drawing.Point(611, 527);
            this.stoppedLabel.Name = "stoppedLabel";
            this.stoppedLabel.Size = new System.Drawing.Size(88, 24);
            this.stoppedLabel.TabIndex = 14;
            this.stoppedLabel.Text = "Stopped";
            // 
            // runningLabel
            // 
            this.runningLabel.AutoSize = true;
            this.runningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.runningLabel.Location = new System.Drawing.Point(610, 527);
            this.runningLabel.Name = "runningLabel";
            this.runningLabel.Size = new System.Drawing.Size(89, 24);
            this.runningLabel.TabIndex = 14;
            this.runningLabel.Text = "Running";
            this.runningLabel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 527);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ordersSelect
            // 
            this.ordersSelect.FormattingEnabled = true;
            this.ordersSelect.Items.AddRange(new object[] {
            "Initial Orders 1",
            "Initial Orders 2"});
            this.ordersSelect.Location = new System.Drawing.Point(417, 527);
            this.ordersSelect.Name = "ordersSelect";
            this.ordersSelect.Size = new System.Drawing.Size(162, 21);
            this.ordersSelect.TabIndex = 12;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // scrOut
            // 
            this.scrOut.Location = new System.Drawing.Point(759, 532);
            this.scrOut.Name = "scrOut";
            this.scrOut.Size = new System.Drawing.Size(100, 20);
            this.scrOut.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "SCR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(875, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cycles";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1211, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scrOut);
            this.Controls.Add(this.ordersSelect);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.countBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.stoppedLabel);
            this.Controls.Add(this.runningLabel);
            this.Name = "MainForm";
            this.Text = "EDSAC";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accumulatorTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplyTube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longTankTube)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tapeInput;
        private System.Windows.Forms.TextBox printerOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox countBox;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox trace;
        private System.Windows.Forms.Button clearOutputButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox ordersSelect;
        private System.Windows.Forms.CheckBox traceEnabled;
        private System.Windows.Forms.Button clearTraceButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label stoppedLabel;
        private System.Windows.Forms.Label runningLabel;
        private System.Windows.Forms.TextBox nextInstruction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dial3;
        private System.Windows.Forms.Button dial6;
        private System.Windows.Forms.Button dial2;
        private System.Windows.Forms.Button dial5;
        private System.Windows.Forms.Button dial9;
        private System.Windows.Forms.Button dial1;
        private System.Windows.Forms.Button dial4;
        private System.Windows.Forms.Button dial8;
        private System.Windows.Forms.Button dial7;
        private System.Windows.Forms.Button dial0;
        private System.Windows.Forms.ComboBox tankSelector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox breakpoints;
        private System.Windows.Forms.TextBox newBreakpoint;
        private System.Windows.Forms.Button newBreakpointButton;
        private System.Windows.Forms.Button deleteBreakpointButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button disCsrButton;
        private System.Windows.Forms.TextBox disassembly;
        private System.Windows.Forms.Button disAddressButton;
        private System.Windows.Forms.TextBox disFrom;
        private System.Windows.Forms.Button disPrevButton;
        private System.Windows.Forms.Button disNextButton;
        private System.Windows.Forms.Button disRefreshButton;
        private System.Windows.Forms.TextBox scrOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button memScrButton;
        private System.Windows.Forms.TextBox memoryDump;
        private System.Windows.Forms.Button memNextButton;
        private System.Windows.Forms.Button memPrevButton;
        private System.Windows.Forms.Button memRefreshButton;
        private System.Windows.Forms.TextBox memAddress;
        private System.Windows.Forms.Button memAddressButton;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox longTankTube;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox scrTube;
        private System.Windows.Forms.CheckBox showScr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox accumulatorTube;
        private System.Windows.Forms.PictureBox orderTube;
        private System.Windows.Forms.PictureBox multiplyTube;
        private System.Windows.Forms.CheckBox showOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox showAccumulator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox showMultiply;
    }
}

