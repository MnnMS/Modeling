namespace BearingMachineSimulation
{
    partial class Form1
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
            this.readBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NhoursTxt = new System.Windows.Forms.TextBox();
            this.NbearTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bearCostTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dwnTimeCTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.repairCostTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.repairTimeBTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.repairTBrsTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bearingDist = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayDist = new System.Windows.Forms.DataGridView();
            this.DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.inputTab = new System.Windows.Forms.TabPage();
            this.currTab = new System.Windows.Forms.TabPage();
            this.totalDelayTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currGridView = new System.Windows.Forms.DataGridView();
            this.PorpTab = new System.Windows.Forms.TabPage();
            this.totalDelay2Txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.propGridView = new System.Windows.Forms.DataGridView();
            this.firstFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prop_accBearingLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prop_RD_DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prop_DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfTab = new System.Windows.Forms.TabPage();
            this.totalCostTxt2 = new System.Windows.Forms.TextBox();
            this.totalRepairCTxt2 = new System.Windows.Forms.TextBox();
            this.totalDownCTxt2 = new System.Windows.Forms.TextBox();
            this.totalDelayCTxt2 = new System.Windows.Forms.TextBox();
            this.totalBearCTxt2 = new System.Windows.Forms.TextBox();
            this.totalCostTxt = new System.Windows.Forms.TextBox();
            this.totalRepairCTxt = new System.Windows.Forms.TextBox();
            this.totalDownCTxt = new System.Windows.Forms.TextBox();
            this.totalDelayCTxt = new System.Windows.Forms.TextBox();
            this.totalBearCTxt = new System.Windows.Forms.TextBox();
            this.curCost = new System.Windows.Forms.Label();
            this.curRepair = new System.Windows.Forms.Label();
            this.curDowntime = new System.Windows.Forms.Label();
            this.curDelay = new System.Windows.Forms.Label();
            this.curBearing = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RD_BearingLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BearingLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accBearingLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curr_RD_DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curr_DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bearingDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayDist)).BeginInit();
            this.tabControl.SuspendLayout();
            this.inputTab.SuspendLayout();
            this.currTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currGridView)).BeginInit();
            this.PorpTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propGridView)).BeginInit();
            this.perfTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.Location = new System.Drawing.Point(837, 13);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(202, 86);
            this.readBtn.TabIndex = 0;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "No of Hours";
            // 
            // NhoursTxt
            // 
            this.NhoursTxt.Location = new System.Drawing.Point(257, 23);
            this.NhoursTxt.Name = "NhoursTxt";
            this.NhoursTxt.ReadOnly = true;
            this.NhoursTxt.Size = new System.Drawing.Size(105, 20);
            this.NhoursTxt.TabIndex = 2;
            // 
            // NbearTxt
            // 
            this.NbearTxt.Location = new System.Drawing.Point(257, 79);
            this.NbearTxt.Name = "NbearTxt";
            this.NbearTxt.ReadOnly = true;
            this.NbearTxt.Size = new System.Drawing.Size(105, 20);
            this.NbearTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "No of Bearings";
            // 
            // bearCostTxt
            // 
            this.bearCostTxt.Location = new System.Drawing.Point(257, 126);
            this.bearCostTxt.Name = "bearCostTxt";
            this.bearCostTxt.ReadOnly = true;
            this.bearCostTxt.Size = new System.Drawing.Size(105, 20);
            this.bearCostTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bearing Cost";
            // 
            // dwnTimeCTxt
            // 
            this.dwnTimeCTxt.Location = new System.Drawing.Point(604, 23);
            this.dwnTimeCTxt.Name = "dwnTimeCTxt";
            this.dwnTimeCTxt.ReadOnly = true;
            this.dwnTimeCTxt.Size = new System.Drawing.Size(105, 20);
            this.dwnTimeCTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "DownTime Cost";
            // 
            // repairCostTxt
            // 
            this.repairCostTxt.Location = new System.Drawing.Point(604, 100);
            this.repairCostTxt.Name = "repairCostTxt";
            this.repairCostTxt.ReadOnly = true;
            this.repairCostTxt.Size = new System.Drawing.Size(105, 20);
            this.repairCostTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Repairperson Cost";
            // 
            // repairTimeBTxt
            // 
            this.repairTimeBTxt.Location = new System.Drawing.Point(604, 177);
            this.repairTimeBTxt.Name = "repairTimeBTxt";
            this.repairTimeBTxt.ReadOnly = true;
            this.repairTimeBTxt.Size = new System.Drawing.Size(105, 20);
            this.repairTimeBTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "RepairTime/Bearing";
            // 
            // repairTBrsTxt
            // 
            this.repairTBrsTxt.Location = new System.Drawing.Point(257, 178);
            this.repairTBrsTxt.Name = "repairTBrsTxt";
            this.repairTBrsTxt.ReadOnly = true;
            this.repairTBrsTxt.Size = new System.Drawing.Size(105, 20);
            this.repairTBrsTxt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "RepairTime/Bearings";
            // 
            // bearingDist
            // 
            this.bearingDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bearingDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Probability});
            this.bearingDist.Location = new System.Drawing.Point(6, 6);
            this.bearingDist.Name = "bearingDist";
            this.bearingDist.Size = new System.Drawing.Size(489, 376);
            this.bearingDist.TabIndex = 17;
            // 
            // Time
            // 
            this.Time.HeaderText = "BearingLife";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            this.Probability.ReadOnly = true;
            // 
            // delayDist
            // 
            this.delayDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delayDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DelayTime,
            this.DTProb});
            this.delayDist.Location = new System.Drawing.Point(501, 6);
            this.delayDist.Name = "delayDist";
            this.delayDist.Size = new System.Drawing.Size(512, 376);
            this.delayDist.TabIndex = 18;
            // 
            // DelayTime
            // 
            this.DelayTime.HeaderText = "DelayTime";
            this.DelayTime.Name = "DelayTime";
            this.DelayTime.ReadOnly = true;
            // 
            // DTProb
            // 
            this.DTProb.HeaderText = "Probability";
            this.DTProb.Name = "DTProb";
            this.DTProb.ReadOnly = true;
            // 
            // simBtn
            // 
            this.simBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simBtn.Location = new System.Drawing.Point(837, 121);
            this.simBtn.Name = "simBtn";
            this.simBtn.Size = new System.Drawing.Size(202, 86);
            this.simBtn.TabIndex = 19;
            this.simBtn.Text = "Simulate";
            this.simBtn.UseVisualStyleBackColor = true;
            this.simBtn.Click += new System.EventHandler(this.simBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "";
            this.tabControl.Controls.Add(this.inputTab);
            this.tabControl.Controls.Add(this.currTab);
            this.tabControl.Controls.Add(this.PorpTab);
            this.tabControl.Controls.Add(this.perfTab);
            this.tabControl.Location = new System.Drawing.Point(12, 219);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1027, 411);
            this.tabControl.TabIndex = 20;
            // 
            // inputTab
            // 
            this.inputTab.Controls.Add(this.bearingDist);
            this.inputTab.Controls.Add(this.delayDist);
            this.inputTab.Location = new System.Drawing.Point(4, 22);
            this.inputTab.Name = "inputTab";
            this.inputTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputTab.Size = new System.Drawing.Size(1019, 385);
            this.inputTab.TabIndex = 0;
            this.inputTab.Text = "Input Tab";
            this.inputTab.UseVisualStyleBackColor = true;
            // 
            // currTab
            // 
            this.currTab.Controls.Add(this.totalDelayTxt);
            this.currTab.Controls.Add(this.label7);
            this.currTab.Controls.Add(this.currGridView);
            this.currTab.Location = new System.Drawing.Point(4, 22);
            this.currTab.Name = "currTab";
            this.currTab.Padding = new System.Windows.Forms.Padding(3);
            this.currTab.Size = new System.Drawing.Size(1019, 385);
            this.currTab.TabIndex = 1;
            this.currTab.Text = "Current Method";
            this.currTab.UseVisualStyleBackColor = true;
            // 
            // totalDelayTxt
            // 
            this.totalDelayTxt.Location = new System.Drawing.Point(882, 360);
            this.totalDelayTxt.Name = "totalDelayTxt";
            this.totalDelayTxt.ReadOnly = true;
            this.totalDelayTxt.Size = new System.Drawing.Size(131, 20);
            this.totalDelayTxt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(752, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Delay";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currGridView
            // 
            this.currGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.RD_BearingLife,
            this.BearingLife,
            this.accBearingLife,
            this.curr_RD_DelayTime,
            this.curr_DelayTime});
            this.currGridView.Location = new System.Drawing.Point(3, 6);
            this.currGridView.Name = "currGridView";
            this.currGridView.Size = new System.Drawing.Size(1010, 348);
            this.currGridView.TabIndex = 0;
            // 
            // PorpTab
            // 
            this.PorpTab.Controls.Add(this.totalDelay2Txt);
            this.PorpTab.Controls.Add(this.label9);
            this.PorpTab.Controls.Add(this.propGridView);
            this.PorpTab.Location = new System.Drawing.Point(4, 22);
            this.PorpTab.Name = "PorpTab";
            this.PorpTab.Padding = new System.Windows.Forms.Padding(3);
            this.PorpTab.Size = new System.Drawing.Size(1019, 385);
            this.PorpTab.TabIndex = 2;
            this.PorpTab.Text = "Proposed Method ";
            this.PorpTab.UseVisualStyleBackColor = true;
            // 
            // totalDelay2Txt
            // 
            this.totalDelay2Txt.Location = new System.Drawing.Point(882, 360);
            this.totalDelay2Txt.Name = "totalDelay2Txt";
            this.totalDelay2Txt.ReadOnly = true;
            this.totalDelay2Txt.Size = new System.Drawing.Size(131, 20);
            this.totalDelay2Txt.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(752, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Delay";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // propGridView
            // 
            this.propGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstFailure,
            this.prop_accBearingLife,
            this.prop_RD_DelayTime,
            this.prop_DelayTime});
            this.propGridView.Location = new System.Drawing.Point(3, 6);
            this.propGridView.Name = "propGridView";
            this.propGridView.Size = new System.Drawing.Size(1010, 348);
            this.propGridView.TabIndex = 1;
            // 
            // firstFailure
            // 
            this.firstFailure.HeaderText = "FirstFailure";
            this.firstFailure.Name = "firstFailure";
            this.firstFailure.ReadOnly = true;
            // 
            // prop_accBearingLife
            // 
            this.prop_accBearingLife.HeaderText = "AccBearingLife";
            this.prop_accBearingLife.Name = "prop_accBearingLife";
            this.prop_accBearingLife.ReadOnly = true;
            // 
            // prop_RD_DelayTime
            // 
            this.prop_RD_DelayTime.HeaderText = "RD_DelayTime";
            this.prop_RD_DelayTime.Name = "prop_RD_DelayTime";
            this.prop_RD_DelayTime.ReadOnly = true;
            // 
            // prop_DelayTime
            // 
            this.prop_DelayTime.HeaderText = "DelayTime";
            this.prop_DelayTime.Name = "prop_DelayTime";
            this.prop_DelayTime.ReadOnly = true;
            // 
            // perfTab
            // 
            this.perfTab.Controls.Add(this.totalCostTxt2);
            this.perfTab.Controls.Add(this.totalRepairCTxt2);
            this.perfTab.Controls.Add(this.totalDownCTxt2);
            this.perfTab.Controls.Add(this.totalDelayCTxt2);
            this.perfTab.Controls.Add(this.totalBearCTxt2);
            this.perfTab.Controls.Add(this.totalCostTxt);
            this.perfTab.Controls.Add(this.totalRepairCTxt);
            this.perfTab.Controls.Add(this.totalDownCTxt);
            this.perfTab.Controls.Add(this.totalDelayCTxt);
            this.perfTab.Controls.Add(this.totalBearCTxt);
            this.perfTab.Controls.Add(this.curCost);
            this.perfTab.Controls.Add(this.curRepair);
            this.perfTab.Controls.Add(this.curDowntime);
            this.perfTab.Controls.Add(this.curDelay);
            this.perfTab.Controls.Add(this.curBearing);
            this.perfTab.Controls.Add(this.label11);
            this.perfTab.Controls.Add(this.label10);
            this.perfTab.Location = new System.Drawing.Point(4, 22);
            this.perfTab.Name = "perfTab";
            this.perfTab.Padding = new System.Windows.Forms.Padding(3);
            this.perfTab.Size = new System.Drawing.Size(1019, 385);
            this.perfTab.TabIndex = 3;
            this.perfTab.Text = "Performance Measures";
            this.perfTab.UseVisualStyleBackColor = true;
            // 
            // totalCostTxt2
            // 
            this.totalCostTxt2.Location = new System.Drawing.Point(757, 300);
            this.totalCostTxt2.Multiline = true;
            this.totalCostTxt2.Name = "totalCostTxt2";
            this.totalCostTxt2.ReadOnly = true;
            this.totalCostTxt2.Size = new System.Drawing.Size(201, 28);
            this.totalCostTxt2.TabIndex = 26;
            this.totalCostTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalCostTxt2.WordWrap = false;
            // 
            // totalRepairCTxt2
            // 
            this.totalRepairCTxt2.Location = new System.Drawing.Point(757, 243);
            this.totalRepairCTxt2.Multiline = true;
            this.totalRepairCTxt2.Name = "totalRepairCTxt2";
            this.totalRepairCTxt2.ReadOnly = true;
            this.totalRepairCTxt2.Size = new System.Drawing.Size(201, 28);
            this.totalRepairCTxt2.TabIndex = 25;
            this.totalRepairCTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalRepairCTxt2.WordWrap = false;
            // 
            // totalDownCTxt2
            // 
            this.totalDownCTxt2.Location = new System.Drawing.Point(757, 186);
            this.totalDownCTxt2.Multiline = true;
            this.totalDownCTxt2.Name = "totalDownCTxt2";
            this.totalDownCTxt2.ReadOnly = true;
            this.totalDownCTxt2.Size = new System.Drawing.Size(201, 28);
            this.totalDownCTxt2.TabIndex = 24;
            this.totalDownCTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalDownCTxt2.WordWrap = false;
            // 
            // totalDelayCTxt2
            // 
            this.totalDelayCTxt2.Location = new System.Drawing.Point(757, 129);
            this.totalDelayCTxt2.Multiline = true;
            this.totalDelayCTxt2.Name = "totalDelayCTxt2";
            this.totalDelayCTxt2.ReadOnly = true;
            this.totalDelayCTxt2.Size = new System.Drawing.Size(201, 28);
            this.totalDelayCTxt2.TabIndex = 23;
            this.totalDelayCTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalDelayCTxt2.WordWrap = false;
            // 
            // totalBearCTxt2
            // 
            this.totalBearCTxt2.Location = new System.Drawing.Point(757, 72);
            this.totalBearCTxt2.Multiline = true;
            this.totalBearCTxt2.Name = "totalBearCTxt2";
            this.totalBearCTxt2.ReadOnly = true;
            this.totalBearCTxt2.Size = new System.Drawing.Size(201, 28);
            this.totalBearCTxt2.TabIndex = 22;
            this.totalBearCTxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalBearCTxt2.WordWrap = false;
            // 
            // totalCostTxt
            // 
            this.totalCostTxt.Location = new System.Drawing.Point(430, 300);
            this.totalCostTxt.Multiline = true;
            this.totalCostTxt.Name = "totalCostTxt";
            this.totalCostTxt.ReadOnly = true;
            this.totalCostTxt.Size = new System.Drawing.Size(201, 28);
            this.totalCostTxt.TabIndex = 21;
            this.totalCostTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalCostTxt.WordWrap = false;
            // 
            // totalRepairCTxt
            // 
            this.totalRepairCTxt.Location = new System.Drawing.Point(430, 243);
            this.totalRepairCTxt.Multiline = true;
            this.totalRepairCTxt.Name = "totalRepairCTxt";
            this.totalRepairCTxt.ReadOnly = true;
            this.totalRepairCTxt.Size = new System.Drawing.Size(201, 28);
            this.totalRepairCTxt.TabIndex = 20;
            this.totalRepairCTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalRepairCTxt.WordWrap = false;
            // 
            // totalDownCTxt
            // 
            this.totalDownCTxt.Location = new System.Drawing.Point(430, 186);
            this.totalDownCTxt.Multiline = true;
            this.totalDownCTxt.Name = "totalDownCTxt";
            this.totalDownCTxt.ReadOnly = true;
            this.totalDownCTxt.Size = new System.Drawing.Size(201, 28);
            this.totalDownCTxt.TabIndex = 19;
            this.totalDownCTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalDownCTxt.WordWrap = false;
            // 
            // totalDelayCTxt
            // 
            this.totalDelayCTxt.Location = new System.Drawing.Point(430, 129);
            this.totalDelayCTxt.Multiline = true;
            this.totalDelayCTxt.Name = "totalDelayCTxt";
            this.totalDelayCTxt.ReadOnly = true;
            this.totalDelayCTxt.Size = new System.Drawing.Size(201, 28);
            this.totalDelayCTxt.TabIndex = 18;
            this.totalDelayCTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalDelayCTxt.WordWrap = false;
            // 
            // totalBearCTxt
            // 
            this.totalBearCTxt.Location = new System.Drawing.Point(430, 72);
            this.totalBearCTxt.Multiline = true;
            this.totalBearCTxt.Name = "totalBearCTxt";
            this.totalBearCTxt.ReadOnly = true;
            this.totalBearCTxt.Size = new System.Drawing.Size(201, 28);
            this.totalBearCTxt.TabIndex = 17;
            this.totalBearCTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalBearCTxt.WordWrap = false;
            // 
            // curCost
            // 
            this.curCost.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curCost.ForeColor = System.Drawing.Color.Firebrick;
            this.curCost.Location = new System.Drawing.Point(58, 300);
            this.curCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curCost.Name = "curCost";
            this.curCost.Size = new System.Drawing.Size(288, 28);
            this.curCost.TabIndex = 5;
            this.curCost.Text = "Total Cost";
            this.curCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curRepair
            // 
            this.curRepair.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curRepair.ForeColor = System.Drawing.Color.Firebrick;
            this.curRepair.Location = new System.Drawing.Point(56, 243);
            this.curRepair.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curRepair.Name = "curRepair";
            this.curRepair.Size = new System.Drawing.Size(290, 28);
            this.curRepair.TabIndex = 6;
            this.curRepair.Text = "Total Repair Person Cost";
            this.curRepair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curDowntime
            // 
            this.curDowntime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curDowntime.ForeColor = System.Drawing.Color.Firebrick;
            this.curDowntime.Location = new System.Drawing.Point(56, 186);
            this.curDowntime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curDowntime.Name = "curDowntime";
            this.curDowntime.Size = new System.Drawing.Size(290, 28);
            this.curDowntime.TabIndex = 7;
            this.curDowntime.Text = "Total Downtime Cost";
            this.curDowntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curDelay
            // 
            this.curDelay.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curDelay.ForeColor = System.Drawing.Color.Firebrick;
            this.curDelay.Location = new System.Drawing.Point(58, 129);
            this.curDelay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curDelay.Name = "curDelay";
            this.curDelay.Size = new System.Drawing.Size(288, 28);
            this.curDelay.TabIndex = 8;
            this.curDelay.Text = "Total Delay Cost";
            this.curDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curBearing
            // 
            this.curBearing.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curBearing.ForeColor = System.Drawing.Color.Firebrick;
            this.curBearing.Location = new System.Drawing.Point(58, 72);
            this.curBearing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.curBearing.Name = "curBearing";
            this.curBearing.Size = new System.Drawing.Size(288, 28);
            this.curBearing.TabIndex = 4;
            this.curBearing.Text = "Total Bearing Cost";
            this.curBearing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(804, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Proposed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(487, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Current";
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // RD_BearingLife
            // 
            this.RD_BearingLife.HeaderText = "RD_BearingLife";
            this.RD_BearingLife.Name = "RD_BearingLife";
            this.RD_BearingLife.ReadOnly = true;
            // 
            // BearingLife
            // 
            this.BearingLife.HeaderText = "BearingLife";
            this.BearingLife.Name = "BearingLife";
            this.BearingLife.ReadOnly = true;
            // 
            // accBearingLife
            // 
            this.accBearingLife.HeaderText = "AccBearingLife";
            this.accBearingLife.Name = "accBearingLife";
            this.accBearingLife.ReadOnly = true;
            // 
            // curr_RD_DelayTime
            // 
            this.curr_RD_DelayTime.HeaderText = "RD_DelayTime";
            this.curr_RD_DelayTime.Name = "curr_RD_DelayTime";
            this.curr_RD_DelayTime.ReadOnly = true;
            // 
            // curr_DelayTime
            // 
            this.curr_DelayTime.HeaderText = "DelayTime";
            this.curr_DelayTime.Name = "curr_DelayTime";
            this.curr_DelayTime.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1051, 642);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.simBtn);
            this.Controls.Add(this.repairTBrsTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.repairTimeBTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.repairCostTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dwnTimeCTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bearCostTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NbearTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NhoursTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bearingDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayDist)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.inputTab.ResumeLayout(false);
            this.currTab.ResumeLayout(false);
            this.currTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currGridView)).EndInit();
            this.PorpTab.ResumeLayout(false);
            this.PorpTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propGridView)).EndInit();
            this.perfTab.ResumeLayout(false);
            this.perfTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NhoursTxt;
        private System.Windows.Forms.TextBox NbearTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bearCostTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dwnTimeCTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox repairCostTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox repairTimeBTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox repairTBrsTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView bearingDist;
        private System.Windows.Forms.DataGridView delayDist;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.Button simBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage inputTab;
        private System.Windows.Forms.TabPage currTab;
        private System.Windows.Forms.TabPage PorpTab;
        private System.Windows.Forms.TabPage perfTab;
        private System.Windows.Forms.TextBox totalDelayTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView currGridView;
        private System.Windows.Forms.TextBox totalDelay2Txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView propGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalCostTxt2;
        private System.Windows.Forms.TextBox totalRepairCTxt2;
        private System.Windows.Forms.TextBox totalDownCTxt2;
        private System.Windows.Forms.TextBox totalDelayCTxt2;
        private System.Windows.Forms.TextBox totalBearCTxt2;
        private System.Windows.Forms.TextBox totalCostTxt;
        private System.Windows.Forms.TextBox totalRepairCTxt;
        private System.Windows.Forms.TextBox totalDownCTxt;
        private System.Windows.Forms.TextBox totalDelayCTxt;
        private System.Windows.Forms.TextBox totalBearCTxt;
        private System.Windows.Forms.Label curCost;
        private System.Windows.Forms.Label curRepair;
        private System.Windows.Forms.Label curDowntime;
        private System.Windows.Forms.Label curDelay;
        private System.Windows.Forms.Label curBearing;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn prop_accBearingLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn prop_RD_DelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prop_DelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn RD_BearingLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn BearingLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn accBearingLife;
        private System.Windows.Forms.DataGridViewTextBoxColumn curr_RD_DelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn curr_DelayTime;
    }
}